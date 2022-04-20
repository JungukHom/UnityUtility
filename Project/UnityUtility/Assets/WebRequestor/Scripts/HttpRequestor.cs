// System
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Collections;
using System.Collections.Generic;

// Unityv
using UnityEngine;
using UnityEngine.UI;

// Project
// Alias

public class HttpRequestor : MonoBehaviour
{
    /*
     * [POST] 192.168.1.250:8081/api/login?email=abc@gmail.com
     * ���� id ����& token�� ���� �϶� -> status 200
     * id ������ -> status 400
     * ���� -> status 500
     * ���·� ��ȯ�ǰ� refresh token�� ������� ���� ���·� ��ȯ�˴ϴ�. �� �κ��� �ڵ��߰��ؼ� �����صΰڽ��ϴ�.
     */
    private class Url
    {
        public static string SERVER_BASE_URL = "192.168.1.250:8081";
    }

    private static HttpRequestor Instance = null;
    private static HttpClient client = new HttpClient();

    private static string refreshToken = string.Empty;
    private static string accessToken = string.Empty;

    public static HttpRequestor GetOrCreate()
    {
        if (Instance == null)
        {
            GameObject gameObject = new GameObject(nameof(HttpRequestor));
            Instance = gameObject.GetComponent<HttpRequestor>();
        }

        return Instance;
    }

    private static void Initialize(string hostBaseUrl)
    {
        client = new HttpClient
        {
            BaseAddress = new Uri(hostBaseUrl)
        };
    }

    private static void SetJwtToken(string jwtToken)
    {
        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + jwtToken);
    }

    //////////////////////////////////////////////////
    
    public static void SetJwtRefreshToken()
    {

    }

    public static void SetJwtAccessToken()
    {

    }

    public static void RequestAuthorization()
    {

    }
}