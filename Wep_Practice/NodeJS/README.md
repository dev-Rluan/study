## Node.js 가이드 
### https://nodejs.org/ko/docs

## Node js의 장점과 단점
### Node 장점
 - I/O처리 잘 하는 노드를 서버로 사용
 * I/O 특화작업: 네트워크, 데이터베이스, 디스크 작업
* 실시간 채팅 어플리케이션
* 주식차트
* JSON 데이터 제공하는 API 서버
* IOT 기기연동
* 데이터의 I/O가 많은 서비스
### Node 단점
 - CPU 부하가 큰 작업에는 부적합
 
* CPU 작업이 많은 서버로는 부적합
* 이미지, 비디오 처리
* 대규모  데이터 처리로 CPU 많이 사용
### 결론
 - 개수는 많지만 크기는 작은 데이터를 실시간으로 주고 받는 작업에 적합
 - 짧은 시간에 대량의 클라이언트 요청에 대응하는 웹 어플리케이션에 적합
 * (대량의 데이터를 조회하고 CPU 사용을 요구하면서 다소 긴 처리시간 요구에는 부적합)

## 사용 순서
- npm init
- npm instal mongo
- npm instal


## 비동기 I/O 
시간이 걸리는 I/O
- 하드디스크 접근
- 데이터베이스 서버
- 네트워크를 이용해서 다른 서비스 접근

* 동기식 : I/O 동작이 끝날 때까지 대기
// 동기식 
var result = db.query("select * from T");
// use result
* 비동기식 : I/o 동작이 끝날 때까지 대기하지 않는다.
// 비동기식
db.query("select * from T, function(result){
    // use result}"
    );
[설명] query함수 호출시, 결과에 따른 후행 작업을 미리 선언하여 인자값으로 넘겨준 것
-> 이벤트 기반 방식

## 이벤트 기반 방식(Event-driven)
이벤트가 발생할 때 미리 지정해 둔 작업을 수행하는 방식

이벤트 리스너(Event-listener)에 콜백 함수 등록
- 노드도 이벤트가 발생하면 이벤트 리스너에 등록해 둔 콜백함수 호출
- 발생한 이벤트 없거나  발생했던 이벤트 다 처리하면 다음 이벤트가 발생할 때까지 대기

## callback함수
### CPU 내부에서  작업하는 것과 달리 상대적으로 느린 네트워크 디스크와 같은 자원을 다루는 대다수의 함수는 콜백함수로 느리게 응답
### 익명함수
- 다른 함수가 종료될 때 실행되도록 설정
- 함수 인자로 전달되는 함수

### 장점 
- 다른 코드를 실행하기 전에 원래 함수의 종료를 기다릴 필요가 없다


## [요약]비동기 방식
### Node.js
- 싱글스레드 : 실제 사용자의 요청을 받는 스레드가 한개
- 논 블록킹 방식
- 비동기 방식

* 메인스레드 : 싱글 스레드
* 워크스레드 : 멀티 스레드 풀 사용
// 논 블로킹  방식 : 값이 아니라 종료되면 함수를 반환

### 비동기 방식
- 메인스레드가 존재하고 메인 스레드는 실제 코드를 실행
1) 메인 스레드가 오래걸린다고 판단하면 내부에 처리하는 다른 스레드로 해당 작업을 넘긴다
2) 메인 스레드에 작업을 받은 스레드는 해당 작업이 끝나면 콜백함수를 메인 스레드에 돌려준다
3) 메인 스레드는 전달받은 콜백함수를 실행한다
이 콜백 함수가 실행될 때 이미 다른 코드가 처리된 이후이다



## NPM : Node Package Manager
- Node.js 패키지/모듈 저장소
- Node.js 패키지 설치 및 버전/호환성 관리
- Node.js로 생성한 패키지/프로젝트 관리하는 도구
init        패키지 정보 설정
install     패키지 설치
uninstall   패키지 삭제
update      패키지 업데이트
search      패키지 검색

### node app.js
npm init    // package.json 생성
npm install // 패키지 설치

npm run start   // npm으로 실행 하거나(start가 스크립트 이름)
node app        // 또는 node 명령으로 실행

### Package.json : Node.js 패키지/프로젝트 정보를 가지고 있는 설정파일 
            노드로 생성한 프로젝트 정보

- name            프로젝트 이름
- version         프로젝트 버전
- description     프로젝트 설명(npm search)
- main            해당 패키지 진입점인 모듈
- script          복잡한 명령르 npm 이용해 단순화
- author          제작자 정보
- license         라이선스(복제, 배포 수정권한 등 )
- keywords        npm에서 패키지 찾을 때 사용
- bugs            사용 중 에러/버그 발생시 알려중 담당자 정보
- dependencies    일반적인 배포환경에서 필요한 의존성 모듈
- devDependencies 개발환경에서 필요(주로 테스팅 모듈 포함)

- 패키지, 서버를 배포할 때
- package.json만 있으면
- npm 으로 설치한 모든 패키지와 함께 배포할 필요 없다

- npm install로 한 번에 설치 가능

    * npm run test
    * npm run start
    * npm run stop
    * npm run delete

## 요약 npm
### npm init 
- 개발자로부터 애플리케이션의 정보를 입력 받고
- 패키지 관리를 위한 package.json 파일을 생성

### npm install
- npm install {패키지명}
 패키지명을 가진 모듈을 설치
- npm install {패키지명} -g
 패키지명을 가진 모듈을 전역 설치

### npm {script명}
- package.json 내에 있는 스크립트를 실행

## http Module
- http Module은 nodejs 기본 서버 모듈
- 요청(request)과 응답(respone)으로 구성
- 클라이언트가 서버로 요청(request)을 보내고
- 서버는 요청을 처리
- 처리 후 클라이언트오 응답(response)을 보냄 
 
 // code

            const http = require('http');
            
            // CreateServer() 뒤에 listen() 메소드
            // res 객체 
            // res.writeHead    응답에 대한 정보 기록
            // res.write        클라이언트에 보낼 데이터
            // res.end          응답 종료
            http.createServer((req, res) => {
                res.writeHead(200, {'Content-Type' : 'text/html; charset=utf-8'});
                res.write('<h1>Hellow Node!</h1>');
                res.end('<p>Hello Server!</p>);
            })
            .listen(3000, () => { // 클라이언트에 공개할 포트번호와 포트 연결 완료 후 실행될 콜백함수 넣는다.          
                console.log('server on : 3000 port')
            });

## Express Module
express Module은 클라이언트와 서버 가운데에 있기 때문에 미들웨어라고 한다.

            const express = require('express');
            const app = express();
 
            // get : 미들웨어 함수 적용할 HTTP 메소드 (post, put 등등)     
            // '/' : 미들웨어 함수 적용할 경로(라우트)
            // function : 미들웨어 함수 
            // req : 미들웨어 함수의 콜백 인자
            // res : 미들웨어 함수의 HTTP 응답(response) 인자
            // next : 미들웨어 함수의 HTTP 요청(request) 인자
            app.get('/', function(req, res, next){
                next();
            });
           
            app.listen(3000, function(){
                console.log('Example app Listening on port 3000');
            });

### Express 미들웨어 함수
미들 웨어 : Express에서 사용하는 모듈
사용자요청을 라우팅하기 위해 콜백 함수 등록

미들웨어 함수 console.log()실행 후 next()로 다음 미들웨어 호출한다.

            const express = require('express');
            const app = express();
            // myLogger  미들웨어 함수
            // - 이 함수가 다른 함수 실행하기전에 먼저 실행 되게 한다
            // - 이 때 next() 를 호출해야 다음 미들웨허 함수를 실행하게 된다
            var myLogger = (req, res, next) => {
                console.log('LOGGED');
                next();                 // 만약 next()가 없다면 서버측에만  첫 번째 미들웨어 출력되고  클라이언트는 아무런 응답을 받지 못한다. 
            }                   
            app.use(myLogger);          // 미들웨어 등록 

            app.get('/', function(req, res, next){
                res.send('Hellow World');
            });
            app.listen(3000, function(){
                console.log('Example app Listening on port 3000');
            })

### Express Router
라우팅
사용자 요청에 따라 응답 결과를 다르게 전달하는 것
js 파일 만들어 작성하고 파일을 분리해서 관리
읽기 쉽고, 유지 보수 쉽게 관리
app.get("/", function(req,res)){
    //
});
app.get("/user", function(req, res){
    //
});
라우팅 설정에 따라 등록된 콜백함수 실행 요청 메소드와 주소별로 분기 처리
-> 코드 복잡
-> 라우터를 분리

const express = require('express'); //  1. express모듈을 불러온다.
const router = express.Router();    //  2. express의 Router객체를 가져온다


### express method
- set(key, value) : 서버 설정을 위한 속성 지정
- get(key) : 서버 설정 속성을 불러옴
- use([path,] function [, function ...]) : 미들웨어 함수 사용
- get(path, callback)  : Get 메서드의 요청을 처리
- post(path, callback) : post 메서드의 요청을 처리
- all(path, callback)  : 모든 요청을 처리

            app.set('port', process.env.PORT || 3000);
            let port = app.get('port')
            http.createServer(app).listen(port, () =>{
                console.log('server on : ' + port)
            });


- env : 서버 환경 설정
- views :  뷰들이 들어있는 폴더(배열)을 설정
- view engine : 기본 뷰 엔진을 설정

## FS Moduel
### FS : 파일에 데이터를 쓰고 읽어 올 수 있는 기능 제공
fs module : file system
비동기식 vs 동기식 // 순서 상관없으면 비동기식
writeFile : 비동기식
- 파일에 데이터를 쓴다
- 파일이 없으면 새로 만들고, 있으면 기존 데이터 삭제하고 쓴다
appendFile : 비동기식
- 파일에 데이터를 쓴다.
- 파일이 없으면 새로 만들고, 있으면 기존 데이터 뒤에 추가로 쓴다
readFile : 비동기식
- 파일 데이터를 읽어온다

writeFileSync : 동기식
- 동기 비동기 이외 writeFile과 같음
appendFileSync : 동기식
- 동기 비동기 이외 appendFile과 같음

//code 



