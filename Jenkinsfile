pipeline {
    agent any

    stages {
        stage('Build') {
      steps {
        // Checkout the GitHub repository
         dir('SessionStateManagementForHighScalability') {
          // Use MSBuild to build the solution file
           bat "msbuild.exe SessionStateManagementForHighScalability.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
       }
      }
    }
  }
}
    
