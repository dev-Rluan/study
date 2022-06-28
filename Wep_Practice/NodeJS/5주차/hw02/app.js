const express = require('express');

let app = express();


// roputer 불러와서 사용
var indexRouter = require('./routes/index');
var usersRouter = require('./routes/users');
var boardRouter = require('./routes/boards');

// router 등록 
app.use('/', indexRouter);
app.use('/users', usersRouter);
app.use('/boards', boardRouter);

const hostname = '127.0.0.1';

const port = 3000;


app.listen(port,hostname, () => {

  console.log(`Express is running on http://${hostname}:${port}/`);

} );