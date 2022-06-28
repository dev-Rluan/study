## MongoDB
### Mongo설치
https://www.mongodb.com
### Robo 3T 설치
https://robomongo.org/download

## MongoDB 특징
### MongoDB 
- 스키마를 고정하지 않는 형태
- 데이터를 구조화해서 JSON형태로 저장(Key-value 저장) 자바스크립트 객체를 그대로 저장 가능
- 조인 불가능(조인 없도록 데이터 설계) One query 가능하도록 미리 embedding시켜야한다
- 인-메모리 형태(메모리 맵) : 메모리 크기가 성능 좌우

## MongoDB 장단점
### 장점
- 성능을 최우선으로 고려(실시간 처리, 대용량 메시징 시스템)
- 쌓아 놓고 삭제가 없는 경우 적합(로그 데이터, 이벤츠 참여내역, 세션 등)
### 단점
- 트랜잭션 필요 경우 부적합
- 금융, 결제, 회원정보 저장에 부적합

## MongoDB 구조
### 1. MongoDb 구조
- 테이블 -> 컬렉션
- 레코드 -> 문서 객체

### 2. 특징 
- 하나의 컬렉션 안에 다양한 자료형 데이터
- 스키마 없다
- 데이터의 갯수와 형태가 정의되어있지 않다

## MongoDB CRUD
## C(Create, Insert)
save()
insert(), insertOne(), insertMany()
## R(Read, Select)
find()
## U(Update)
updateOne(), updateMany()
## D(Delete)
remove() 
deleteOne(), deleteMany()

