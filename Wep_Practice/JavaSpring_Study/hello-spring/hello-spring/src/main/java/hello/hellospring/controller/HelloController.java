package hello.hellospring.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class HelloController {

    @GetMapping("hello")
    public String hello(Model model){
        model.addAttribute("data", "hello!!");
        return "hello";
    }

    @GetMapping("hello-mvc")
    public String hellowMvc(@RequestParam(name = "name", required = true) String name, Model model){
        model.addAttribute("name", name);
        return "hello-templates";
    }

    /*
    @ResponseBody 를 사용
    - http 의 body 에 문자내용을 직접 반환
    - viewResolver 대신에 HttpMessageConverter 가 동작
    - 기본 문자처리 StringHttpMessageConverter
    - 기본 객체처리 MappingJackson2HttpMessageConverter   : 객체를 json 형태로 변환
    - byte 처리 등등 기타 여러 HttpMessageConverter 가 기본으로 등록되어있음
     */

    @GetMapping("hello-string")
    @ResponseBody   // httpMessageConverter로 전달 없으면 view resolver로 던져준다.
    public String helloString(@RequestParam("name") String name){

        return "hello " + name;     // "hello name"
    }

    @GetMapping("hello-api")
    @ResponseBody
    public  Hello helloApi(@RequestParam("name") String name){
        Hello hello = new Hello();
        hello.setName(name);
        return hello;   // 객체를 보내면 디폴트로 json 형태로 보낸다.
    }

    static class Hello{

        private String name;


        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }



    }

}
