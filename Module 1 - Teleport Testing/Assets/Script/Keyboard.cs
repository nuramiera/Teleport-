using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Keyboard: MonoBehaviour
{

    public InputField TextField;
    public SteamVR_LaserPointer laserPointer;
    string alphabet;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "A")
        {
            Debug.Log("A was clicked");
            A();
        }
        else if (e.target.name == "B")
        {
            Debug.Log("B was clicked");
            B();
        }
        else if (e.target.name == "C")
        {
            Debug.Log("C was clicked");
            C();
        }
        else if (e.target.name == "D")
        {
            Debug.Log("D was clicked");
            D();
        }
        else if (e.target.name == "E")
        {
            Debug.Log("E was clicked");
            E();
        }
        else if (e.target.name == "F")
        {
            Debug.Log("F was clicked");
            F();
        }
        else if (e.target.name == "G")
        {
            Debug.Log("G was clicked");
            G();
        }
        else if (e.target.name == "H")
        {
            Debug.Log("H was clicked");
            H();
        }
        else if (e.target.name == "I")
        {
            Debug.Log("I was clicked");
            I();
        }
        else if (e.target.name == "J")
        {
            Debug.Log("J was clicked");
            J();
        }
        else if (e.target.name == "K")
        {
            Debug.Log("K was clicked");
            K();
        }
        else if (e.target.name == "L")
        {
            Debug.Log("L was clicked");
            L();
        }
        else if (e.target.name == "M")
        {
            Debug.Log("M was clicked");
            M();
        }
        else if (e.target.name == "N")
        {
            Debug.Log("N was clicked");
            N();
        }
        else if (e.target.name == "O")
        {
            Debug.Log("O was clicked");
            O();
        }
        else if (e.target.name == "P")
        {
            Debug.Log("P was clicked");
            P();
        }
        else if (e.target.name == "Q")
        {
            Debug.Log("Q was clicked");
            Q();
        }
        else if (e.target.name == "R")
        {
            Debug.Log("R was clicked");
            R();
        }
        else if (e.target.name == "S")
        {
            Debug.Log("S was clicked");
            S();
        }
        else if (e.target.name == "T")
        {
            Debug.Log("T was clicked");
            T();
        }
        else if (e.target.name == "U")
        {
            Debug.Log("U was clicked");
            U();
        }
        else if (e.target.name == "V")
        {
            Debug.Log("V was clicked");
            V();
        }
        else if (e.target.name == "W")
        {
            Debug.Log("W was clicked");
            W();
        }
        else if (e.target.name == "X")
        {
            Debug.Log("X was clicked");
            X();
        }
        else if (e.target.name == "Y")
        {
            Debug.Log("Y was clicked");
            Y();
        }
        else if (e.target.name == "Z")
        {
            Debug.Log("Z was clicked");
            Z();
        }
        else if (e.target.name == "Coma")
        {
            Debug.Log("Coma was clicked");
            Coma();
        }
        else if (e.target.name == "FullStop")
        {
            Debug.Log("FullStop was clicked");
            FullStop();
        }
        else if (e.target.name == "BackSpace")
        {
            Debug.Log("BackSpace was clicked");
            BackSpace();
        }
        else if (e.target.name == "Space")
        {
            Debug.Log("Space was clicked");
            Space();
        }
        else if (e.target.name == "1")
        {
            Debug.Log("1 was clicked");
            One();
        }
        else if (e.target.name == "2")
        {
            Debug.Log("2 was clicked");
            Two();
        }
        else if (e.target.name == "3")
        {
            Debug.Log("3 was clicked");
            Three();
        }
        else if (e.target.name == "4")
        {
            Debug.Log("4 was clicked");
            Four();
        }
        else if (e.target.name == "5")
        {
            Debug.Log("5 was clicked");
            Five();
        }
        else if (e.target.name == "6")
        {
            Debug.Log("6 was clicked");
            Six();
        }
        else if (e.target.name == "7")
        {
            Debug.Log("7 was clicked");
            Seven();
        }
        else if (e.target.name == "8")
        {
            Debug.Log("8 was clicked");
            Eight();
        }
        else if (e.target.name == "9")
        {
            Debug.Log("9 was clicked");
            Nine();
        }
        else if (e.target.name == "0")
        {
            Debug.Log("0 was clicked");
            Zero();
        }
    }

    public void A()
    {
        TextField.text = TextField.text + "A";
    }

    public void B()
    {
        TextField.text = TextField.text + "B";
    }

    public void C()
    {
        TextField.text = TextField.text + "C";
    }

    public void D()
    {
        TextField.text = TextField.text + "D";
    }

    public void E()
    {
        TextField.text = TextField.text + "E";
    }

    public void F()
    {
        TextField.text = TextField.text + "F";
    }

    public void G()
    {
        TextField.text = TextField.text + "G";
    }

    public void H()
    {
        TextField.text = TextField.text + "H";
    }

    public void I()
    {
        TextField.text = TextField.text + "I";
    }

    public void J()
    {
        TextField.text = TextField.text + "J";
    }

    public void K()
    {
        TextField.text = TextField.text + "K";
    }

    public void L()
    {
        TextField.text = TextField.text + "L";
    }

    public void M()
    {
        TextField.text = TextField.text + "M";

    }

    public void N()
    {
        TextField.text = TextField.text + "N";
    }

    public void O()
    {
        TextField.text = TextField.text + "Q";
    }

    public void P()
    {
        TextField.text = TextField.text + "P";
    }

    public void Q()
    {
        TextField.text = TextField.text + "Q";
    }

    public void R()
    {
        TextField.text = TextField.text + "R";
    }

    public void S()
    {
        TextField.text = TextField.text + "S";
    }

    public void T()
    {
        TextField.text = TextField.text + "T";
    }

    public void U()
    {
        TextField.text = TextField.text + "U";
    }

    public void V()
    {
        TextField.text = TextField.text + "V";
    }

    public void W()
    {
        TextField.text = TextField.text + "W";
    }

    public void X()
    {
        TextField.text = TextField.text + "X";
    }

    public void Y()
    {
        TextField.text = TextField.text + "Y";
    }

    public void Z()
    {
        TextField.text = TextField.text + "Z";
    }

    public void FullStop()
    {
        TextField.text = TextField.text + ".";
    }

    public void Coma()
    {
        TextField.text = TextField.text + ",";
    }

    public void BackSpace()
    {

        if (TextField.text.Length > 0) TextField.text = TextField.text.Remove(TextField.text.Length - 1);

    }

    public void Space()
    {
        TextField.text = TextField.text + " ";
    }

    public void One()
    {
        TextField.text = TextField.text + "1";
    }

    public void Two()
    {
        TextField.text = TextField.text + "2";
    }

    public void Three()
    {
        TextField.text = TextField.text + "3";
    }
    public void Four()
    {
        TextField.text = TextField.text + "4";
    }
    public void Five()
    {
        TextField.text = TextField.text + "5";
    }
    public void Six()
    {
        TextField.text = TextField.text + "6";

    }
    public void Seven()
    {
        TextField.text = TextField.text + "7";
    }
    public void Eight()
    {
        TextField.text = TextField.text + "8";
    }
    public void Nine()
    {
        TextField.text = TextField.text + "9";
    }
    public void Zero()
    {
        TextField.text = TextField.text + "0";
    }

}
