node('DOTNETCORE'){
	stage('scm'){

		checkout([
				$class: 'GitSCM', 
				branches: [[name: '*/main']], 
				doGenerateSubmoduleConfigurations: false, 
				extensions: [], 
				submoduleCfg: [], 
				userRemoteConfigs: [[url: 'https://github.com/apatel999/dotnetcore']]
			])
		
	}
	stage('Build'){
		sh 'dotnet build ConsoleApp1'
	}
}