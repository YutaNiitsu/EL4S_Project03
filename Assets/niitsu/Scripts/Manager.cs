using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Manager;

public class Manager : MonoBehaviour
{
    [SerializeField] public GameObject AccelerationPrefab;
    [SerializeField] public GameObject SlowingDownPrefab;
    [SerializeField] public GameObject FreezePrefab;
    [SerializeField] public GameObject GodmodePrefab;
    [SerializeField] public AudioSource GameBGM;
    [SerializeField] public float GoalDistance = 1000;
    [SerializeField] public Vector3 ItemSpawnOffset;
    [SerializeField] public ItemSpawn[] ItemSpawnSettings;
    private Player PlayerRef;
    private Vector3 PlayerStartPosition;
    private Transform PlayerTransform;
    private float TimeCount = 0;

     [System.Serializable]
    public enum ItemType
    {
        Acceleration,
        SlowingDown,
        Freeze,
        Godmode
    }
    [System.Serializable]
    public struct ItemSpawnSetting
    {
        [Header("�o�����������A�C�e���̎��")] public ItemType type;
        [Header("�o���m��")] public float ratio;
    }

    [System.Serializable]
    public struct ItemSpawn
    {
        [Header("�v���C���[�̈ړ�����")] public float PlayerMoveDistance;
        [Header("�A�C�e���o���p�x�i��/�b�j")] public float ratio;
        [Header("�A�C�e���o���ݒ�")] public ItemSpawnSetting[] itemSpawnSettings;
    }

    //public struct ItemSpawnCount
    //{
    //    public float TimeCount;
    //    public bool IsSpawn;
    //}

    // Start is called before the first frame update
    void Start()
    {
        PlayerRef = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (GameBGM != null) GameBGM.Play();
    }
    private void FixedUpdate()
    {
        TimeCount += Time.deltaTime;
        ItemInstantiate();
    }
    // Update is called once per frame
    void Update()
    {

    }

    // �X�^�[�g����S�[���܂ł̋����ɑ΂���i�񂾊���
    public float GetPlayerMovingDistanceRatio()
    {
        return PlayerRef.GetMoveDistance() / GoalDistance;
    }

    void ItemInstantiate()
    {
        // �v���C���[�ړ�����
        float dist = PlayerRef.GetMoveDistance();
        int index = 0;
        foreach (ItemSpawn itr in ItemSpawnSettings)
        {
            if (itr.PlayerMoveDistance >= dist)
            {
                break;
            }
            index++;
        }
        if (TimeCount > 1 / ItemSpawnSettings[index].ratio)
        {
            TimeCount = 0;
        }
        else
        {
            return;
        }
        float rnd = Random.Range(0.0f, 1.0f);
        float rnd2 = Random.Range(-4.0f, 4.0f);
        float ratio = 0;
        // �A�C�e���ݒ�擾
        foreach (ItemSpawnSetting itr in ItemSpawnSettings[index].itemSpawnSettings)
        {
            if (ratio <= rnd && ratio + itr.ratio > rnd)
            {
                Vector3 pos = new Vector3(0.0f, rnd2, 0.0f) + ItemSpawnOffset;
                Quaternion q = new Quaternion(0, 0, 0, 0);
                if (itr.type == ItemType.Acceleration) Instantiate(AccelerationPrefab, pos, q);
                if (itr.type == ItemType.SlowingDown) Instantiate(SlowingDownPrefab, pos, q);
                if (itr.type == ItemType.Freeze) Instantiate(FreezePrefab, pos, q);
                if (itr.type == ItemType.Godmode) Instantiate(GodmodePrefab, pos, q);
                Debug.Log(itr.type.ToString());
                break;
            }
            ratio += itr.ratio;
        }
    }
}
