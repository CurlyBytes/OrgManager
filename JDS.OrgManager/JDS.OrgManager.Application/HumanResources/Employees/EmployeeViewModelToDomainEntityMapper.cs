// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Application.Abstractions.Mapping;
using JDS.OrgManager.Application.Common.Addresses;
using JDS.OrgManager.Application.HumanResources.Employees;
using JDS.OrgManager.Domain.Common.Addresses;
using JDS.OrgManager.Domain.Common.Finance;
using JDS.OrgManager.Domain.HumanResources.Employees;
using Mapster;
using System;
using System.Linq;

namespace JDS.OrgManager.Application.Common.Mapping
{
    public partial class EmployeeViewModelToDomainEntityMapper
    {
        private readonly IViewModelToValueObjectMapper<IAddressViewModel, Address> addressMapper;

        public EmployeeViewModelToDomainEntityMapper(IViewModelToValueObjectMapper<IAddressViewModel, Address> addressMapper) => this.addressMapper = addressMapper ?? throw new ArgumentNullException(nameof(addressMapper));

        protected override TypeAdapterSetter<EmployeeViewModel, Employee> Configure(TypeAdapterSetter<EmployeeViewModel, Employee> typeAdapterSetter)
            => base.Configure(typeAdapterSetter)
                .Map(dest => dest.HomeAddress, src => addressMapper.Map(src))
                .Map(dest => dest.Salary, src => new Money(src.Salary, Currency.GetByCode(src.CurrencyCode)));
    }
}