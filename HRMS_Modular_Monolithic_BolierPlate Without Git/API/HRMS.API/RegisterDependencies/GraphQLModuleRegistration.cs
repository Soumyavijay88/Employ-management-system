using HotChocolate.Execution.Configuration;
using OnboardingFeature.GraphQL;
using TodoFeature.GraphQL;

namespace HRMS.API.RegisterDependencies
{
    public static class GraphQLModuleRegistration
    {
        public static IRequestExecutorBuilder AddGraphQLModules(this IRequestExecutorBuilder builder)
        {
            return builder
                .AddTodosGraphQL()
                .AddOnboardingGraphQL();
        }
    }
}
