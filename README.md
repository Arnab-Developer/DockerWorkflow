Example pattern to create application with .NET and Docker

Workflows:

- Pull request to main, build and test the code.
- If needed, pull request can be deployed by manually execution the `docker-push-pr` workflow.
- Push to main or merge a pull request to main, build docker image and push to GitHub package.
- When a release has been created then build docker image and push to dockerhub.

https://hub.docker.com/r/45862391/dockerworkflow