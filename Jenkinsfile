pipeline {
    agent any

    stages {
        stage('Build') {
      steps {
        // Checkout the GitHub repository
        checkout([$class: 'GitSCM', 
                  branches: [[name: '*/main']], 
                  extensions: [[$class: 'RelativeTargetDirectory', 
                  relativeTargetDir: 'SessionStateManagementForHighScalability']], 
                  userRemoteConfigs: [[url: 'https://github.com/Abhishekc18/Session-State-Management.git']]])

          // Use MSBuild to build the solution file
          bat "msbuild.exe SessionStateManagementForHighScalability.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
        
      }
    }
  }
}
    
