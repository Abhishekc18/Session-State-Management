pipeline {
    agent { 
        node {
            label 'docker-agent-dotnet'
            }
      }
    stages {
        stage('Build') {
            steps {
                echo "Building.."
                sh '''
                cd SessionStateManagementForHighScalability
                dotnet build  SessionStateManagementForHighScalability.sln
                '''
            }
        }
        }
    }
}
