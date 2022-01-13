using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] data = { "일련번호", "학과", "이름", "취미", "기업1", "기업2", "기업3" };

        UnityEngine.Debug.Log("제 정보입니다!");
        UnityEngine.Debug.Log(data[0] + "는 05번 입니다");
        UnityEngine.Debug.Log(data[1] + "는 정보시스템공학과 입니다");
        UnityEngine.Debug.Log(data[2] + "은 김지혜 입니다");
        UnityEngine.Debug.Log(data[3] + "는 넷플릭스 보기 입니다.");
        UnityEngine.Debug.Log("제가 가고싶은 " +data[4] + "는 구글 입니다");
        UnityEngine.Debug.Log(data[5] + "는 카카오 입니다.");
        UnityEngine.Debug.Log(data[6] + "는 네이버 입니다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
