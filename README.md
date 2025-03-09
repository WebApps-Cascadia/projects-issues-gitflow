# Github Projects and Gitflow
## Preparation
- Be sure you have accepted the invitation (via email) to the GitHub Learning team

- Review the [Feature branch Workflow tutorial](https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow)

- Review how to resolve merge conflicts - [VSCode](https://code.visualstudio.com/docs/sourcecontrol/overview)

- Review [Reviewing Code Changes via Pull Request](https://help.github.com/en/articles/requesting-a-pull-request-review)

## Outcomes
- Experiment with a GitHub repository - Pull-requests, Merging, and Code Review
- Step through the Gitflow work flow used in the team process
- Practice using Git with Visual Studio, making commits, resolving merge conflicts
## Instructions
### Open, Edit and Commit in Visual Studio
 **DO NOT FORK**  - we want to work together on SHARED code, so we will all [CLONE](https://code.visualstudio.com/docs/sourcecontrol/overview#_cloning-a-repository) the repository [projects-issues-gitflow exercise](https://github.com/WebApps-Cascadia/projects-issues-gitflow)

0) Change to the develop branch
1) Create a new branch based on develop, call it _sign-in-yourName_ (this will be your feature branch) and check out this new branch
2) Us VSCode to modify the sign-in.txt code to add your name to the file as shown
3) Commit the changes
4) Push your feature branch to Github
5) Add a Pull Request from your branch to develop
6) Assign me as a Reviewer in your Pull Request
7) Review someone else's code from their Pull Request; Post a friendly comment to their code
8) Wait and check back on the repository to see if I have merged your code yet
### Pull-Merge-Commit-Push-Request Review
_Plan to do this several times since I will be changing the develop branch as other student's edit the code_
#### From the Terminal window in VS Code
0) Be sure you are in the directory for this project
1) Type the command "git status" or "git branch" to see which branch you are on
2) If you are not on your feature branch, use the command "checkout _branch-name_"
3) Type "git pull origin develop" to pull the current copy of the develop branch from the server (origin) and start to merge it to your branch
#### From Visual Studio Code Editor
Edit the sign-in.txt file using the editor or the Merge tool. Make whatever changes you need to the file  so that **ALL** of the existing names are included as shown in the list and your name is at the bottom
3) Finish the Merge by creating a Commit of your changes

#### Back in the Terminal window
0) Be sure you are in the directory for this project
1) Type "git status" or "git branch" to be sure you are on your feature branch
2) Type "git push origin _branch-name_" to push the updated feature branch to the server
#### From Github
0) Navigate to your Pull request
1) Review your pull request to see that it shows that it is able to be merged
2) If not, Request a Review (or re-Request a Review) from me
3) While you're here, take a moment to review another team member's code and post a comment within their code, from their open pull request.
4) Check out any reviews of your code; respond to at least one comment
#### Repeat over the next few days
Review your pull request details to see if your branch has conflicts with the current develop branch. (Somebody else's branch has been merged ahead of you or other changes were made to develop)

Resolve the conflicts using the"Pull-Merge-Commit-Push-Request Review" step above (redo the entire process from pulling the develop branch to pushing your feature branch and requesting a new review) - notice that the code continue to incorporate new names into develop.

Repeat until I merge your branch and close your pull request

### Finished?
- You accepted my invitation to join GitHub teams
- You edited your feature branch  with your name at the bottom of the list pushed to the remote server
- You created a pull request on GitHub for your feature branch submitted to the remote develop branch
- You commented on at least one other team member's pull request, including a comment within another team member's code
- You responsed to one of the comments you received
- You repeated the steps of the Pull Request cycle using the Git command line and Visual Studio at least four times:
0) Pull develop from GitHub (CL)
1) Resolve merge conflicts it into your feature branch by modifying your feature branch code to make it "right" again (VSC)
3) Push your feature branch to GitHub (CL)