var express = require('express');
var app = express();

app.get('/', (req, res) => {    //res = respone 응답
    res.send('Hellow World!');
  });

  app.listen(3000,() => {
      console.log('Example App listening on port 3000');
  })