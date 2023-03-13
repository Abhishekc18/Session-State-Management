pipeline {
    agent any

    stages {
        stage('Build') {
      steps {
        // Checkout the GitHub repository
         dir('SessionStateManagementForHighScalability') {
          // Use MSBuild to build the solution file
           sh 'dotnet build  SessionStateManagementForHighScalability.sln'
       }
      }
    }
  }
}
    
