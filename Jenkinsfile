pipeline {
    agent { docker { image 'mcr.microsoft.com/dotnet/aspnet:6.0' } }

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
    
