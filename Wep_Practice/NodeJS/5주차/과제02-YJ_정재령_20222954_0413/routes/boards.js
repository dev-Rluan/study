var express = require('express');
var router = express.Router();


router.get('/boards', (req, res, next) => {
    res.send('게시글 가져오기')
  });
  
  
  router.post('/boards', (req, res, next) => {
    res.send('게시글 쓰기')
  });
  
  
  router.put('/boards/:id', (req, res, next) => {
    res.send('게시글 수정')
  });
  
  
  router.delete('/boards/:id', (req, res, next) => {
  
    res.send('게시글 삭제')
  
  });
  
  module.exports = router;
