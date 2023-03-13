pipeline {
    agent any

    stages {
        stage('Build') {
      steps {
        // Checkout the GitHub repository
        checkout([$class: 'GitSCM',
                  branches: [[name: 'main']],
                  doGenerateSubmoduleConfigurations: false,
                  extensions: [],
                  submoduleCfg: [],
                  userRemoteConfigs: [[url: 'https://DevOpsDemoAbhi@dev.azure.com/DevOpsDemoAbhi/Session%20State%20Management/_git/Session%20State%20Management']]])

        // Change to the repository folder
        dir("SessionStateManagementForHighScalability") {
          // Use MSBuild to build the solution file
          bat "msbuild.exe SessionStateManagementForHighScalability.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
        }
      }
    }
    }
}
    
