using Octokit;

namespace UmbracoProject.Code
{
    public class GithubHelper
    {
        public static IReadOnlyList<Repository> GetRepositories(string organization)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            return client.Repository.GetAllForOrg(organization).Result;
        }
    }
}
