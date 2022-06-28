관계형 데이터베이스
- 하나의 고성능 기계에 데이터 저장
- 공통된 형태의 데이터 저장방식( 테이블 )
- 공통된 접근방식(SQL)

- 데이터의 관계를 Foreign Key 로 정의하고 
- 이를 이용해 조인 등의 관계형 연산(비교 요소가 많아지면 속도저하의 요인이 된다.)

NoSQL(Not only SQL)
- 일반적인 서버 수십대를 연결해 데이터를 저장 및 처리하는 구조
- 분산형 구조를 통해 데이터를 여러 대의 서버에 분산하여 저장
- 분산 시에 데이터를 상호 복제해 특정 서버에 장애 발생했을 때 데이터 유실이나 서비스 중지가 없는 상태
- RDBS와 다른 형태의 데이터 저장 구조
-> RDBMS와 다르게 테이블의 스키마가 유동적

- RDBMS 복잡도와 용량 한계를 극복하기 위한 목적으로 등장
- 페타바이트 급의 대용량 데이터를 저장 가능
-> 새로훈 형태의 데이터 저장 기술을 요구

ID로 사용하는 키 부분에만 타입이 동일하고 mandatory 필드로 지정하면 값에 해당하는 컬럼은 어떤 타입이거나 어떤 이름이거나 허용된다.
(ID 필드는 공통이지만, 데이터를 저장하는 컬럼은 각기 다른 이름과 다른 데이터 타입을 가질 수 있다 )

- 고정된 스키마 없다(스키마 리스)
- 정해진 규격이 없다.
- Join 문법 존재하지 않는다.

- 데이터베이스 다루는 인터페이스가 다르다.

저장방식		상품명
-------------------------------------------------
key/value		Redis
wide column 	H-Base, Cassandra
Document	MongoDB, CouchDB
Graph		Neo4j


MongoDB Collection : MongoDB Document의 집합
		RBMS Table과 유사한 개념 
		단, 정규화 구조(schema) 정의되어 있지 않음
- 스키마리스(Schema-less)
 고정된 스키마 없음
 RDBMS의 테이블과 달리 데이터를 정해 놓은 필드 형태로 넣어햐 한다는 제약이 없다.
- 하나의 컬렉션 안에 다양한 데이터 형식을 사용할 수 있다.
 컬렉션 : 여러 데이터가 모인 하나의 단위

- 관계형 데이터베이스의 SQL을 사용하지 않는다.
 데이터 저장, 데이터 조회하는 방법을 별도로 제공
 자바스크립트 객체를 그대로 저장할 수 있다.

비동기식( 실시간 )
동기식( 새로고침해야 보임 )

# mongoDB Download
https://www.mongodb.com/

#Robo 3T Download
https://robomongo.org/download

Mongodb 실행

1. Mongodb 데몬 실행
- Mongodb 설치된 위치 들어가기
cd "mongoDB폴더"\bin\
- Mongodb 데몬 실행
mongod --dbpath c:\data\db
(C:\data\db 위치는 db 저장할 위치)

2. Mongodb 실행
- Mongodb 설치된 위치 들어가기
cd "mongoDB폴더"\bin\
- Mongodb 실행
mongo
3. Mongodb 정상종료
>use admin
>db.shutdownServer();

mongoDB database 생성
use mongodb_basic

robo3t사용
- 데몬 실행후 프로그램에서 연결할 데이터베이스 ip와 host를 연결하고 
- 저장후 connect한다.
- Collections에 table생성 (Create Collection)
- 내용삽입 : insert document

## MongoDB CRUD
### MongoDB의 CRUD는 RDBMS의 CRUD와는 다르다

## C(CREATE, INSERT)
### 메서드 종류
- save()	
- insert(), insertOne(), insertMany()

### Collection생성
- MongoDB에서는 테이블 개념이 없다.
- 바로 Collection에 저장
- Collection : 여러 데이터가 모인 하나의 단위(정해놓은 필드형태로 넣을필요가 없다) 
- 


## R(READ)
### 메서드 종류
- find()

### Find() 논리연산
- $gt : 보다 큰
- $gte : 보다 크거나 같은
- $lt : 보다 작은
- $lte : 보다 작거나 같은
- $in : ㅁㅁ와  ㅁㅁ인
- $nin : ㅁㅁ와 ㅁㅁ이 아닌
- $eq : 같은
- $ne : 같지않은

### 예시코드

			db.people.find({user_id:3}});		// people Collection에서 user_id가 3인 Collection 찾기
			db.people.find({user_id:{$gt:3}}});	// people Collection에서 user_id가 3보다 큰 Collection 찾기
			
## U(UPDATE)
### 메서드 종류
- updateOne(), updateMany()

## D(DELETE)
### 메서드 종류
- remove()
- deleteOne(), deleteMany()

## 




