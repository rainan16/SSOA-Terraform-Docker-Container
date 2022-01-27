[![docker-compose-push-test-action](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/docker-publish-test.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/docker-publish-test.yml)
[![CodeQL](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codeql-analysis.yml)
[![Codacy Security Scan](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codacy-analysis.yml/badge.svg)](https://github.com/rainan16/SSOA-Terraform-Docker-Container/actions/workflows/codacy-analysis.yml)

# SSOA-Terraform-Docker-Container

## Prerequisites to run GITHUB Actions

In github, GITHUB_SECRECTS must be set to run the Actions:

Docker:

```DOCKER_HUB_USERNAME```

```DOCKER_HUB_PASSWORD```

Signing with cosign:

```COSIGN_KEY```

```COSIGN_PASSWORD```

Update [.env](.env) and [.env.test](.env.test) the Dockerhub repository:

```DOCKERHUBNAME```

### Signing container

The container signing action uses ```COSIGN_KEY``` and ```COSIGN_PASSWORD```. Therefore, the public key to check signature has to be stored in [.github/workflows/cosign.bup](.github/workflows/cosign.bup).
