[![docker-compose-push-action](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/docker-publish.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/docker-publish.yml)
[![CodeQL](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codeql-analysis.yml)
[![Codacy Security Scan](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codacy-analysis.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codacy-analysis.yml)

# SSOA-Terraform-Docker-Container

## Prerequisites to run Github Actions

### Github secrets

GITHUB_SECRECTS must be set using Github > Repository > Settings to run Github Actions:

Docker:

```DOCKER_HUB_USERNAME```

```DOCKER_HUB_PASSWORD```

Signing with cosign:

```COSIGN_KEY```

```COSIGN_PASSWORD```

### Dockerhub docker-compose push

Docker images are uploaded to Dockerhub via docker-compose (using .env files).

To push to a different repository, both files, [.env](.env) and [.env.test](.env.test) should point to the new Dockerhub repository: ```DOCKERHUBNAME```

### Signing and verifying container

The container signing action uses ```COSIGN_KEY``` and ```COSIGN_PASSWORD```. Therefore, the public key to check signature has to be stored in [.github/workflows/cosign.bup](.github/workflows/cosign.bup).

Anybody can verify the images on dockerhub by using cosing, e.g.:

```console
cosign verify --key .github/workflows/cosign.pub rainan/blazorserviceguessmyui:latest
```

#### Known Issues >>

Currently, the push destination (Dockerhub repository) is hardcoded in "publish-actions". To access other repos, these Github Actions must be modified!
