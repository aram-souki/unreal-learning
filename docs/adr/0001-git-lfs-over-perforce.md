# Git + Git LFS (on GitHub) instead of Perforce

This project's version control is Git with Git LFS for binary assets (`.uasset`, `.umap`, etc.), hosted on GitHub — not Perforce, despite Perforce being the conventional "industry standard" answer for Unreal projects with binary assets.

Perforce was ruled out for two compounding reasons. First, during the solo-learning phase, self-administering a Helix Core server teaches Perforce operations, not Unreal — pure overhead for one person. Second, and more durably: this curriculum is explicitly meant to transfer to a small team of 3 afterward, with a hard constraint of no hosting cost and no local/self-hosted server. Perforce's free tier (5 users / 20 workspaces) only covers a self-administered server — there's no genuinely free *hosted* Perforce option. Git + LFS on GitHub is free with a ceiling instead (1 GB LFS storage/bandwidth per month, ~$5/50GB beyond that), which fits the constraint at both the solo and team stage without ever requiring server administration.

GitHub over GitLab: reuses the same host as the deferred self-hosted-Actions-runner CI/CD idea, and the free LFS quota is enough to cover the learning phase.
