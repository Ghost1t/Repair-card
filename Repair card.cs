/* ������
TFlex.Model.Technology.dll
TFlex.Reporting.CAD.dll
TFlex.Reporting.Technology.dll
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TFlex.DOCs.Model.Macros;
using TFlex.DOCs.Model.Macros.ObjectModel;
using TFlex.Model.Technology.Macros.ObjectModel;
using TFlex.Reporting.Technology.Macros;

public class Macro : MacroProvider
{
    public Macro(MacroContext context)
        : base(context)
    {
        //System.Diagnostics.Debugger.Launch();
        //System.Diagnostics.Debugger.Break();
    }

    public override void Run()
    {

    }

    public string ���������������_�_�������������()
    {

        string US = "";
        ������� ����������� = �������������.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {
                US = US + ��������.��������["�����"] + "+" + ��������.��������["������������"] + "+";
                ������ ������������� = ��������.���������������["���������������� �������������"];
                if (������������� != null)
                {
                    US = US + ��������.���������������["���������������� �������������"].��������["������������"];
                }
                US = US + ";";
            }
        }
        return US;
    }
    public string �������������������_�_���������()
    {

        string US = "";
        ������� ����������� = �������������.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ���������������������� ����������2 = (����������������������)����������;
            ��������[] ��������� = ����������2.���������;
            int �������������������� = ���������.Length;
            if (�������������������� > 0)
            {
                foreach (������ �������� in ���������)
                {
                    US = US + ��������.��������["������� ������������ ���������"] + "+";

                    string r1 = ��������.��������["����� ��������� �� ������"];
                    string r2 = ��������.��������["������ ��������� �� ������"];
                    if ((r1 != "") && (r1 != "0"))
                    {
                        if ((r2 != "") && (r2 != "0"))
                            US = US + r1 + "x" + r2;
                        else
                            US = US + "L=" + r1;
                    }
                    else
                        if ((r2 != "") && (r2 != "0"))
                        US = US + r2;
                }
                US = US + "+";
            }
            else
            {
                US = "++";
            }

            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {
                ������ ������������� = ��������.���������������["���������������� �������������"];
                if (������������� != null)
                {
                    US = US + ��������.���������������["���������������� �������������"].��������["������������"] + "+";
                }
                US = US + ��������.��������["�����"] + "+" + ��������.��������["������������"];

                �������� ��������2 = (��������)��������;
                ���������[] ��������� = ��������2.���������;
                int ������������������� = ���������.Length;
                if (������������������� > 0)
                {
                    foreach (������ ��������� in ���������)
                    {
                        US = US + "+" + ���������.��������["������ ���������"];
                    }
                }
                US = US + ";";
            }
        }
        return US;
    }
    public ������� ����������������������(ObjectAccessor[] arr, string �����������������)
    {
        ������� �������������� = new �������();
        foreach (var obj in arr)
        {
            ������ ������ = obj.���������������[�����������������];
            if (������ != null)
                ��������������.Add(������);
        }
        return ��������������;
    }

    public string �������������������_���_����������()
    {

        string US = "";
        ������� ����������� = �������������.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ���������������������� ����������2 = (����������������������)����������;
            ������� ��������� = ����������2.����������������["������������"];
            foreach (var �������� in ���������)
            {
                string ��� = "���������-������������ �����";
                string ������������ = ��������.��������["������������"];

                if (������������.Contains(���))
                {
                    US = US + "+" + ��������.��������["�����������"];
                }

            }


            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {

                �������� ��������2 = (��������)��������;


                ���������[] ��������� = ��������2.���������;
                int ������������������� = ���������.Length;
                if (������������������� > 0)
                {
                    foreach (������ ��������� in ���������)
                    {
                        US = US + "+" + ���������.��������["������ ���������"];
                    }
                }
                US = US + ";";
            }
        }
        return US;
    }

    public string �������������������_c_��������()
    {
        string[] Filter_VO = new string[]{"��","��","��","��","��","��","��","�-","�-","1�","2�","3�",
        "4�","5�","6�","7�","8�","9�","��","��","��","��","��","1�","2�","3�","4�","5�","6�","7�","1�","2�","3�","4�","5�","6�"};
        string US = "";
        ������� ����������� = �������������.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ���������������������� ����������2 = (����������������������)����������;
            ������� ��������� = ����������2.����������������["������������"];
            foreach (var �������� in ���������)
            {
                string ��� = "���������-������������ �����";
                string ������������ = ��������.��������["������������"];

                if (������������.Contains(���))
                {
                    US = US + "+" + ��������.��������["�����������"];
                }

            }


            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {

                �������� ��������2 = (��������)��������;


                List<���������> ���������������2 = new List<���������>();
                ���������������2.AddRange(��������2.���������);
                foreach (������� �������2 in ��������2.��������)
                {
                    ���������������2.AddRange(�������2.���������);
                }


                int ������������������� = ���������������2.Count;
                if (������������������� > 0)
                {
                    foreach (������ ���������2 in ���������������2)
                    {

                        ������ ������������2 = ���������2.���������������["��������� �� ����������� ���"];
                        if (������������2 == null)
                            continue;

                        string ���� = ������������2.��������["������������"];
                        string ���_������� = ����.Substring(0, 2);           //�������� ������ ��� ����� ��������� (��; ��; �� � �� � �.�.)
                        if (Filter_VO.Contains(���_�������))
                        {
                            US = US + "+" + ������������2.��������["������������"];
                        }
                    }
                }
            }
        }
        return US;
    }

    public string �������������()
    {
        string K = "�����������";
        string P = "�����������";
        string T = "��������������� ����������";
        string Result = "";
        string G = "������������";
        string L = "������������";

        ������� ����������� = �������������.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ���������������������� ����������2 = (����������������������)����������;

            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {
                �������� ��������2 = (��������)��������;

                string ���������� = ��������2.��������["������������"];

                if (����������.Contains(K) || ����������.Contains(P) || ����������.Contains(T))
                {

                    foreach (������� �������2 in ��������2.��������)
                    {

                        string ������������� = �������2.��������["����� ��������"];

                        if (�������������.Contains(G) || �������������.Contains(L))
                        {
                            Result += "+" + ��������2.��������["������������"] + "+" + �������2.��������["����� ��������"];
                        }

                    }

                }
            }
        }
        return Result;
    }


    public List<Guid> ������_�������������()
    {
        string K = "�����������";
        string P = "�����������";
        string T = "��������������� ����������";
        string G = "������������";
        string L = "������������";

        List<Guid> ������� = new List<Guid>();
        ������� ������������ = ������������("����������� ��������� �������", "[���] = '�������'");
        ������� �� = ������������("����������� ��������� �������", "[���] = '��������� �������'");
        ������� ������ = ������������("����������� ��������� �������", "[���] = '������'");

        List<������> ����1 = new List<������>(������������);
        List<������> ����2 = new List<������>(��);
        List<������> ����3 = new List<������>(������);
        ����1.AddRange(����2);
        ����1.AddRange(����3);

        ������� ������ = ����1;

        foreach (������ ������� in ������)
        {
            ������� ����������� = �������.����������������["�����������"];



            foreach (������ ���������� in �����������)
            {
                ���������������������� ����������2 = (����������������������)����������;

                ������� �������� = ����������.���������������;
                foreach (������ �������� in ��������)
                {
                    �������� ��������2 = (��������)��������;
                    if (��������2 != null)
                    {
                        string ���������� = ��������2.��������["������������"];

                        if (����������.Contains(K) || ����������.Contains(P) || ����������.Contains(T))
                        {

                            foreach (������� �������2 in ��������2.��������)
                            {

                                string ������������� = �������2.��������["����� ��������"];

                                if (�������������.Contains(G) || �������������.Contains(L))
                                {
                                    �������.Add(�������.Guid);

                                    ������� ����������� = �������.������������������;

                                    foreach (var �������� in �����������)
                                    {
                                        �������.Add(��������.Guid);

                                    }


                                }

                            }

                        }
                    }
                }
            }
        }
        return �������;
    }

    public List<Guid> ������_�������������_���������()
    {
        string K = "�����������";
        string P = "�����������";
        string T = "��������������� ����������";
        string G = "������������";
        string L = "������������";


        List<Guid> ������� = new List<Guid>();
        ������� ������������ = ������������("����������� ��������� �������", "[���] = '�������'");
        ������� �� = ������������("����������� ��������� �������", "[���] = '��������� �������'");
        ������� ������ = ������������("����������� ��������� �������", "[���] = '������'");

        List<������> ����1 = new List<������>(������������);
        List<������> ����2 = new List<������>(��);
        List<������> ����3 = new List<������>(������);
        ����1.AddRange(����2);
        ����1.AddRange(����3);

        ������� ������ = ����1;

        foreach (������ ������� in ������)
        {
            ������� ����������� = �������.����������������["�����������"];



            foreach (������ ���������� in �����������)
            {
                ���������������������� ����������2 = (����������������������)����������;

                ������� �������� = ����������.���������������;
                foreach (������ �������� in ��������)
                {
                    �������� ��������2 = (��������)��������;
                    if (��������2 != null)
                    {
                        string ���������� = ��������2.��������["������������"];

                        if (����������.Contains(K) || ����������.Contains(P) || ����������.Contains(T))
                        {

                            foreach (������� �������2 in ��������2.��������)
                            {

                                string ������������� = �������2.��������["����� ��������"];

                                if (�������������.Contains(G) || �������������.Contains(L))
                                {
                                    string ������� = �������.��������["�����������"];
                                    ������ �������� = �����������("���������", "�����������", �������);
                                    �������.Add(��������.Guid);


                                }

                            }

                        }
                    }
                }
            }
        }
        return �������;
    }

    public string �������������_���������()
    {
        string K = "�����������";
        string P = "�����������";
        string T = "��������������� ����������";
        string Result = "";
        string G = "������������";
        string L = "������������";
        string ������� = �������������.��������["�����������"];
        ������ ��� = �����������("����������� ��������� �������", "�����������", �������);
        ������� ����������� = ���.����������������["�����������"];
        foreach (������ ���������� in �����������)
        {
            ���������������������� ����������2 = (����������������������)����������;

            ������� �������� = ����������.���������������;
            foreach (������ �������� in ��������)
            {
                �������� ��������2 = (��������)��������;

                string ���������� = ��������2.��������["������������"];

                if (����������.Contains(K) || ����������.Contains(P) || ����������.Contains(T))
                {

                    foreach (������� �������2 in ��������2.��������)
                    {

                        string ������������� = �������2.��������["����� ��������"];

                        if (�������������.Contains(G) || �������������.Contains(L))
                        {
                            Result += "+" + ��������2.��������["������������"] + "+" + �������2.��������["����� ��������"];
                        }

                    }

                }
            }
        }
        return Result;
    }
}