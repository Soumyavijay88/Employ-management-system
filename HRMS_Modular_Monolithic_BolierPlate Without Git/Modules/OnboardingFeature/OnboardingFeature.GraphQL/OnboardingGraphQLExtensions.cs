using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnboardingFeature.GraphQL.Mutations;
using OnboardingFeature.GraphQL.Queries;
using OnboardingFeature.GraphQL.Types;

namespace OnboardingFeature.GraphQL
{
    public static class OnboardingGraphQLExtensions
    {
        public static IRequestExecutorBuilder AddOnboardingGraphQL(this IRequestExecutorBuilder builder)
        {
            return builder
                .AddType<OnboardingTaskType>()
                .AddTypeExtension<OnboardingMutations>()
                .AddTypeExtension<OnboardingQueries>();
        }
    }
}
