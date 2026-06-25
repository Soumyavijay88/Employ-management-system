using HRMS.Shared.Domain.Entity;
using HotChocolate.Types;

namespace OnboardingFeature.GraphQL.Types
{
    public class OnboardingTaskType : ObjectType<OnboardingTask>
    {
        protected override void Configure(IObjectTypeDescriptor<OnboardingTask> descriptor)
        {
            descriptor.Field(t => t.Id).Type<NonNullType<IdType>>();
            descriptor.Field(t => t.EmployeeId).Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Title).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Description).Type<StringType>();
            descriptor.Field(t => t.Order).Type<NonNullType<IntType>>();
            descriptor.Field(t => t.IsCompleted).Type<NonNullType<BooleanType>>();
            descriptor.Field(t => t.CompletedOn).Type<DateTimeType>();
            descriptor.Field(t => t.Category).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.CreatedByUserId).Type<StringType>();
            descriptor.Field(t => t.CreatedOn).Type<DateTimeType>();
            descriptor.Field(t => t.ModifiedByUserId).Type<StringType>();
            descriptor.Field(t => t.ModifiedOn).Type<DateTimeType>();
        }
    }
}
