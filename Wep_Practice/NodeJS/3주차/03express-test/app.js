// express module로 돌아가는 프레임워크 
const express = require('express');
const app = express();

 
const hostname = '127.0.0.1';
const port = 3000;

app.get('/', (req, res) => {    //res = respone 응답
  res.send('<H1>Hello World!!!!!</H1>');
});

app.get('/sayhello/:name', (req, res) => {    //res = respone 응답
  res.status(200);      // 
  let name = req.params.name;
  res.send(`Hello, ${name}`);   // 변수 포함되었을때는  ` 으로 막는다 주의할 것 
});



app.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
}); 