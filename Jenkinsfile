pipeline {
    agent any

    stages {
        // stage("Checkout") {
        //     steps {
        //         // This command will clone the master branch of the given repository (url)
        //         //      using the GRSampleClassLib credentials added to the Jenkins Git plugin
        //         git url: "https://github.com/dodSONSoftware/GitHub-Test",
        //             branch: "main",
        //             credentialsId: "dodSONSoftware-GitHub"
        //     }
        // }

        stage("SonarCloud Scan") {
            environment {
                SCANNER_HOME = tool 'SonarQubeScanner'

                // must provide these values
                ORGANIZATION = "dodsonsoftware"
                PROJECT_NAME = "GitHub-Test"
            }
            steps {
                // withSonarQubeEnv('Sonarcloud-Server') {
                //     sh '''$SCANNER_HOME/bin/sonar-scanner -Dsonar.organization=$ORGANIZATION \
                //             -Dsonar.java.binaries=build/classes/java/ \
                //             -Dsonar.projectKey=$PROJECT_NAME \
                //             -Dsonar.sources=.'''
                // }

                //withSonarQubeEnv('Sonarcloud-Server') {
                    //sh 'dotnet tool update --global dotnet-sonarscanner'
                    sh '/home/ubuntu/.dotnet/tools/dotnet-sonarscanner begin /k:"GitHub-Test"'
                    sh 'dotnet build -c Release "${env.WORKSPACE}/src/ClassLib/Globeranger.Sample.ClassLib"'
                    sh 'dotnet /home/ubuntu/.dotnet/tools/dotnet-sonarscanner end'
                //}
            }
        }

        // stage("Build") {
        //     steps {                
        //         dir ("${env.WORKSPACE}/src/ClassLib/Globeranger.Sample.ClassLib") {

        //             sh "cat ICalculator.cs"

        //             // clean, restore and build -> {workspace}/publish
        //             sh "dotnet clean"
        //             sh "dotnet restore"
        //             sh "dotnet build -c Release"
        //         }
        //     }
        // }

        stage("Unit Test") {
            steps {
                // run the unit tests    
                dir ("${env.WORKSPACE}/src/ClassLib/Globeranger.Sample.ClassLib.UnitTests") {
                    sh "dotnet test"
                }
            }
        }
        
        stage("Package NuGet") {
            steps {            
                dir ("${env.WORKSPACE}/src/ClassLib/Globeranger.Sample.ClassLib") {
                    // pack -> {workspace}/nuget
                    sh "dotnet pack -c Release --output '${env.WORKSPACE}/nuget'"
                }
            }
        }

        stage("Look At It") {
            steps {
                dir ("${env.WORKSPACE}/nuget") {
                    sh "pwd"
                    sh "ls -la"
                }
            }
        }
        
        // stage("Publish NuGet Package") {
        //     steps {            
        //         dir ("${env.WORKSPACE}/nuget") {
        //             // // publish nuget package
        //             // // sh "dotnet nuget push ${env.WORKSPACE}/nuget/Globeranger.Sample.ClassLib.35.0.0-dev-1.nupkg -k scdktgs6ejqidadkl2yrnmrigoy6jtyas7erezpkc6jj3ojxgmoa -s 'https://pkgs.dev.azure.com/globeranger/_packaging/GlobeRanger/nuget/v3/index.json'"
        //             // sh "dotnet nuget push ./Globeranger.Sample.ClassLib.35.0.0-beta-1.nupkg -k scdktgs6ejqidadkl2yrnmrigoy6jtyas7erezpkc6jj3ojxgmoa -s https://pkgs.dev.azure.com/globeranger/_packaging/GlobeRanger/nuget/v3/index.json"

        //             sh "echo Create the NuGet Package"
        //         }
        //     }
        // }

        // stage("Version NuGet Package") {
        //     steps {            
        //         dir ("${env.WORKSPACE}/nuget") {

        //             // these step represent a techniqued called 'Repackaging'
        //             //     see: https://blog.inedo.com/nuget/how-to-use-cicd-pipelines-for-packages
        //             sh "echo 'Download the Package'"
        //             sh "echo 'Unzip the Package'"
        //             sh "echo 'Edit the Package''s ''.nuspec'' manifest file'"
        //             sh "echo 'Upload the Package'"
        //         }
        //     }
        // }
    }
}
