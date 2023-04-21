using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // �̗�
    private int power = 25; // �U����
    private int mp = 53; // ���W�ۑ�@�Fint�^�̕ϐ�mp��錾���A53�ŏ���������

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W��^����");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // ���W�ۑ�A: mp������Ė��@�U��������Magic�֐����쐬����
    public void Magic()
    {
        // ���W�ۑ�B: mp��5�ȏ�̎���5���炵�A�R���\�[���Ɂu���@�U���������B�c��MP�́����B�v�ƕ\������
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        // ���W�ۑ�B: mp������Ȃ��ꍇ�A�uMP������Ȃ����߁A���@���g���Ȃ��B�v�ƕ\������
        else if (mp < 5)
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �ʏ�ۑ�@: �v�f�̌���5�́Aint�^�̔z��array��錾���āA�D���Ȓl�ŏ���������
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // �ʏ�ۑ�A: for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        // �ʏ�ۑ�B: for�����g���A�z��̊e�v�f�̒l���t���ɕ\������
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        // ���W�ۑ�C: Magic�֐����Ăяo���Ė��@���g��
        lastboss.Magic();
        // ���W�ۑ�D: Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁAmp������Ȃ����b�Z�[�W��\������
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }
}
