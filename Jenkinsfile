node {
    stage('SCM Checkout') {
        git 'https://github.com/subhashmeena/web-app.git'
    }

    stage('Build Docker Image') {
        sh 'docker build -t laxmikantk/test1:latest .'
    }
}