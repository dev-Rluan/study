package hello.core.member;

import hello.core.AppConfig;
import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class MemberServiceTest {
    AppConfig appConfig = new AppConfig();
    MemberService memberService = appConfig.memberService();

    @BeforeEach
    public void beforeEach(){
        AppConfig appConfig = new AppConfig();
        memberService = appConfig.memberService();
    }

    @Test
    void join(){
        // given(이런이런게 주어졋을때)
        Member member = new Member(1L, "memberA", Grade.VIP);

        // when(이렇게 했을때)
        memberService.join(member);
        Member findMember = memberService.findMember(1L);

        // then(이렇게 된다)
        Assertions.assertThat(member).isEqualTo(findMember);


    }

}
