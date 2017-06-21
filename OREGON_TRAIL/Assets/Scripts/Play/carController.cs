using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carController : MonoBehaviour {


    private int _orderCount;
    private int _orderNumber;

    public KeyCode _key;
    
    public int _playerCount;

    public GameObject[] _players;

    // Use this for initialization
    void Start () {
        _orderCount = 0;
        switch(_playerCount)
        {
            case 2:
                var car1 = Instantiate(_players[0], new Vector3(-3, 0.7f,0), Quaternion.Euler(0,90,0));
                var car2 = Instantiate(_players[1], new Vector3(3, 0.6f, 0), Quaternion.Euler(0, -90, 0));
                _players[0] = car1;
                _players[1] = car2;
                break;
            case 3:
                var car3 = Instantiate(_players[0], new Vector3(-3, 0.7f, 0), Quaternion.Euler(0, 90, 0));
                var car4 = Instantiate(_players[1], new Vector3(0, 0.6f, 3), Quaternion.Euler(0, -180, 0));
                var car5 = Instantiate(_players[2], new Vector3(3, 0.7f, 0), Quaternion.Euler(0, -90, 0));
                _players[0] = car3;
                _players[1] = car4;
                _players[2] = car5;
                break;
            case 4:
                var car6 = Instantiate(_players[0], new Vector3(-3, 0.7f, 0), Quaternion.Euler(0, 90, 0));
                var car7 = Instantiate(_players[1], new Vector3(0, 0.6f, 3), Quaternion.Euler(0, -180, 0));
                var car8 = Instantiate(_players[2], new Vector3(3, 0.7f, 0), Quaternion.Euler(0, -90, 0));
                var car9 = Instantiate(_players[3], new Vector3(0, 0.6f, -3), Quaternion.Euler(0, 0, 0));
                _players[0] = car6;
                _players[1] = car7;
                _players[2] = car8;
                _players[3] = car9;
                break;
        }

        
	}

    // Update is called once per frame
    void Update() {
        print(_players.Length);

        if (GameObject.FindGameObjectsWithTag("Car").Length==1)
        {
            SceneManager.LoadScene("Result");
        }
        switch(_playerCount)
        {
            case 2:
            switch (_orderCount)
            {
                case 0:
                        if (_players[0] == null)
                        {

                        }
                        else
                        {
                            _key = KeyCode.A;
                        }
                        break;
                case 1:
                        if (_players[1] == null)
                        {

                        }
                        else
                        {
                            _key = KeyCode.L;
                        }
                    break;
                default:
                    print("エラー");
                    break;
            }
            break;

            case 3:
                switch (_orderCount)
                {
                    case 0:
                        if (_players[0]==null)
                        {

                        }
                        else
                        {
                            _key = KeyCode.Q;
                        }
                        break;
                    case 1:
                        if (_players[1] == null)
                        { }
                        else
                        {
                            _key = KeyCode.B;
                        }
                        break;
                    case 2:
                        if (_players[2] == null)
                        {
                            _key = KeyCode.P;
                        }
                        break;
                    default:
                        print("エラー");
                        break;
                }
            break;

            case 4:
                switch (_orderCount)
                {
                    case 0:
                        if (_players[0] == null)
                        { }
                        else
                        {
                            _key = KeyCode.Q;
                        }
                        break;
                    case 1:
                        if (_players[1] == null)
                        {
                        }
                        else
                        {
                            _key = KeyCode.Z;
                        }
                        break;
                    case 2:
                        if (_players[2] == null)
                        {
                        }
                        else
                        {
                            _key = KeyCode.M;
                        }
                        break;
                    case 3:
                        if (_players[3] == null)
                        {
                           
                        }
                        else
                        {
                            _key = KeyCode.P;
                        }
                        break;
                    default:
                        print("エラー");
                        break;
                }
            break;
        }

        
        

        _players[_orderCount].GetComponent<carMove>().Rote();

        if (Input.GetKeyDown(_key))
        {
             _players[_orderCount].GetComponent<carMove>().Move();
            _orderCount++;
        }
        if (_orderCount >= _playerCount)
        {
            _orderCount = 0;
        }
        if (_players[_orderCount] == null)
        {
            _orderCount++;
        }

        if (_orderCount >= _playerCount)
        {
            _orderCount = 0;
        }


    }
}
