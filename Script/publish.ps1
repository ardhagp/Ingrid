    # Get inputs.
    $docPath = '$(env:build.ArtifactStagingDirectory)\*'
    $githubusername = 'ardhagp'
    $githubemail = '${env:VAR_G_EMAIL}'
    $githubaccesstoken = '$(env:var_G_TOKEN_GITHUB)'
    $repositoryname = 'Ingrid'
    $branchName = 'publish'
    $commitMessage = 'Release v$(env:VAR_G_INGRIDVERSION_MAJOR).$(env:VAR_G_INGRIDVERSION_MINOR).$(env:VAR_G_INGRIDVERSION_BUILD).$(env:VAR_G_INGRIDVERSION_REVISION)'

    $defaultWorkingDirectory = '$(env:System.DefaultWorkingDirectory)'
    
    Write-Host "Cloning existing GitHub repository"

    git clone https://${githubusername}:$githubaccesstoken@github.com/$githubusername/$repositoryname.git --branch=$branchName $defaultWorkingDirectory\ghpages --progress
    
    if ($lastexitcode -gt 0)
    {
        Write-Host "##vso[task.logissue type=error;]Unable to clone repository - check username, access token and repository name. Error code $lastexitcode"
        [Environment]::Exit(1)
    }
    
    $to = "$defaultWorkingDirectory\ghpages"

    Write-Host "Copying new documentation into branch"

    Copy-Item $docPath $to -recurse -Force

    Write-Host "Committing the GitHub repository"

    cd $defaultWorkingDirectory\ghpages
    git config core.autocrlf false
    git config user.email $githubemail
    git config user.name $githubusername
    git add *
    git commit --allow-empty -m $commitMessage

    if ($lastexitcode -gt 0)
    {
        Write-Host "##vso[task.logissue type=error;]Error committing - see earlier log, error code $lastexitcode"
        [Environment]::Exit(1)
    }

    git push --quiet

    if ($lastexitcode -gt 0)
    {
        Write-Host "##vso[task.logissue type=error;]Error pushing to $branchName branch, probably an incorrect Personal Access Token, error code $lastexitcode"
        [Environment]::Exit(1)
    }