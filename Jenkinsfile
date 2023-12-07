pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:8.0' // Using .NET 8.0 Docker image
            args '-v /var/run/docker.sock:/var/run/docker.sock'
        }
    }

    triggers {
        githubPush()
        pullRequest()

    }

    environment {
        // Define your CODACY_PROJECT_TOKEN here or in Jenkins credentials
        CODACY_PROJECT_TOKEN = credentials('codacy-project-token')
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Generate coverage XML report') {
            steps {
                sh 'dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover'
            }
        }

        stage('Upload coverage report to Codacy') {
            steps {
                sh 'bash <(curl -Ls https://coverage.codacy.com/get.sh) report -r ./csdemo.tests/coverage.opencover.xml'
            }
        }

        stage('Run Codacy Analysis CLI with Docker') {
            steps {
                sh '''
                    export CODACY_CODE=$WORKSPACE
                    docker run \
                        --rm=true \
                        --env CODACY_CODE="$CODACY_CODE" \
                        --volume /var/run/docker.sock:/var/run/docker.sock \
                        --volume "$CODACY_CODE":"$CODACY_CODE" \
                        --volume /tmp:/tmp \
                        codacy/codacy-analysis-cli \
                        analyze --upload --project-token $CODACY_PROJECT_TOKEN --max-allowed-issues 99999 --commit-uuid $GIT_COMMIT
                '''
            }
        }
    }
}
