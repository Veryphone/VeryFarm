﻿using UnityEngine;
using System.Collections;

public class TestWWW : MonoBehaviour {

	// Use this for initialization
    void Awake()
    {
        //Screen.SetResolution(1280, 720, true);
    }
	// Update is called once per frame
	void Update () {
	
	}


    private IEnumerator PingToServer()
    {
        Debug.Log("Begin connect....");
        int ServerConnectionTimeOut = 2;
        string post_url = "http://gamefarm.sunkhoai.com/get_score_mission.php?mission=2&fb_ids=647059494,835617839,1135988143,10204595429223008,1210253413,1277118986,1477134886,1551405543,1696968208,1713930716,1771731628,1775988867,1816555140,1829196233,1835235321,955531774457020,100000047754038,100000056259441,100000057515721,100000058288103,100000141485850,100000168415489,100000237529676,100000259633570,100000292489728,100000292553266,100000299270217,100000324659151,100000324879418,100000405146989,100000414638508,100000431341752,100000433425547,100000448652928,100000509536855,100000510603594,100000639024021,100000672659139,100000854940038,100000951877374,100000977002053,100000995622962,100001018564311,100001031852105,100001118977697,100001132301765,100001142149621,100001180681166,100001183695500,100001372870483,818824134840757,100001428138109,100001432238036,100001435691639,100001437458219,100001439010997,100001459484658,100001466933210,100001470726599,100001480251098,100001510406192,100001512216359,100001517051684,100001591912192,100001602730549,100001604416381,100001622846317,100001634029884,100001643154240,100001647953594,100001648147899,100001657802450,100001662266315,100001677101983,100001690420770,100001692797573,100001718735631,100001726350717,100001727995950,100001729035808,100001734740415,100001740859725,100001749367777,100001753461888,100001762622491,100001765234799,100001778963885,100001779258518,100001780382448,100001782975680,100001788830002,100001801585394,100001802215286,100001806215197,100001807108348,100001813080516,100001820426641,100001823052508,100001826433346,100001832295596,100001833827862,100001841494293,100001853496838,100001889739624,100001893879087,100001938435208,100001990373549,100002010419033,100002126952342,100002160723330,100002165722744,100002177739847,100002214618534,100002248485204,100002259637633,100002288043032,100002289620105,100002310524772,100002312315782,100002321676417,100002336710616,100002344353581,100002344418153,100002345478751,100002348729133,100002350485441,100002351636928,100002352704251,100002358216930,100002381810182,100002398562462,717481421675150,100002399627095,100002403420960,100002414686449,100002425514578,100002446660933,100002449302091,100002450543916,100002453893230,100002458124821,100002476726525,100002484342302,100002535124682,100002541312247,100002542258777,100002560453552,100002579304911,100002583468495,100002597465064,100002661368565,100002680510170,100002699933387,100002714341888,100002715130651,100002718421290,100002721083094,100002724802827,100002743249628,100002748593067,100002769972425,100002793141079,100002808044254,100002813998274,100002820839107,100002830227599,100002843006814,100002843532474,100002852182705,100002861501022,100002864228413,100002873700428,100002883806828,100002893020429,100002894205095,100002906241986,100002906806759,100002912812581,100002913037453,100002915124759,100002920851740,100002921442515,100002923285300,100002924688079,100002924812707,100002928594203,100002937652617,100002941930401,100002942671644,100002945405648,100002946717761,100002950877247,100002953451252,100002970584568,100002973675143,100002974800253,100002975037854,100002977533989,100002980871690,100002984057547,100002986779538,100002990621597,100002993412467,100003005997993,100003007514038,100003010477639,100003012785809,100003012798838,100003014173231,100003015877602,100003020042802,100003029440973,100003035700674,100003037955518,100003042293721,100003044376917,100003045046792,100003046013590,100003047101410,100003048813570,100003054280298,100003059311540,100003075840463,100003077216886,100003077541820,100003092128061,100003093327628,100003093503884,100003098668057,100003099049938,100003100679145,100003100706772,100003100921786,100003106181994,100003106471902,100003108351158,100003108473268,100003108949778,100003112381261,100003115432331,100003120223923,100003124877085,100003126808944,100003126896373,100003134381861,100003135129134,100003142046947,100003148635500,100003150396465,674559152659153,100003161296423,100003163467596,100003166856589,100003170047154,100003178599507,100003179439450,100003180551153,100003181271442,100003189436666,100003192246774,100003195085369,100003202463840,100003205950452,100003207495583,100003221059547,100003225744328,100003226780827,100003233019192,100003236036673,100003239890586,100003247477534,100003250887655,100003252416313,100003255634489,100003257363927,100003273227158,100003286105591,100003295060207,100003307774604,100003340246088,100003341682669,100003351194676,640423446080373,100003466576233,100003468780040,100003475497161,100003492992798,100003501975243,100003505672634,100003510701080,100003511858757,100003518568362,100003532075121,100003537003871,100003541281663,100003547690747,100003574903598,100003588125632,100003611588228,100003613210105,100003628539060,100003638167188,100003654484095,100003658322444,100003659283455,100003677839285,100003684903096,100003687085955,100003703353336,100003718357644,100003718764519,100003727667858,100003734996190,100003738708492,100003745372048,100003762326200,100003765873074,100003774067164,100003784008251,100003784584285,100003795229579,100003798388434,100003799233907,100003801364500,100003801587638,100003806924449,100003817070176,100003818383596,100003818751746,100003830968660,100003832955288,100003833170770,100003836162883,100003863630489,100003888427489,100003888979184,100003896605278,100003897270648,100003899073200,100003909190151,100003911559884,100003928206415,100003936157465,100003938184704,100003954841080,100004002411056,100004008289458,100004024376921,100004045522958,100004048217010,100004054892447,100004061282972,100004062924826,100004066230775,100004073700894,100004075362583,100004085331807,100004085710490,100004086033295,100004098575168,100004100000491,100004101939266,100004110215127,100004112763264,100004126894497,100004128403509,100004157648289,393691250779747,100004170189011,100004182540805,100004186208576,100004204003273,100004219687668,100004225059181,100004230398042,100004242120493,100004259045780,100004271912729,100004272640305,100004282056870,100004290784083,100004293781847,100004310949030,100004320398156,100004338152610,100004339001532,100004340683061,100004357830753,100004359304416,100004372925661,100004387514525,100004411300489,100004424946384,100004432086945,100004445165959,100004451011344,100004476545057,100004501211593,100004501898781,100004584218720,100004587784578,100004611007292,100004615127682,100004645774938,100004651115300,100004653907380,100004664880424,100004672752506,100004680548437,100004702146411,100004726387429,100004728129631,100004746728103,100004772675286,100004855352282,100004855602031,100004860872332,100004869337768,100004880171335,100004900265396,100004961670546,100004973469501,100004977544223,100005022992125,100005044481019,100005070584022,100005072049546,100005086990969,100005115125716,100005155982486,100005212596679,100005219018592,100005250787185,100005281449494,100005318162690,100005320902694,100005333523035,100005344230098,100005346013295,100005350714661,100005379037435,100005429349247,100005448817835,100005473952822,100005474538899,100005475274628,100005523693702,100005548217775,100005568000436,100005580910544,100005616874538,100005619398712,100005621072983,100005672433377,100005741315757,100005754043301,100005769122081,100005784753321,100005790631065,100005829426606,100005861225886,100006051581199,100006068918181,100006199871894,100006243065719,100006258103134,100006263254660,100006272713107,100006283475040,100006302712005,100006310801726,100006322534272,100006338672455,100006366874820,100006408636364,100006457624640,100006458616007,100006485031914,100006509166250,100006558109491,100006679500300,100006724449145,100006729332880,100006872370681,100006901845011,100006912007387,100006937330784,100006979176865,100006999607685,100007002720456,100007005792438,100007021750196,100007024931966,100007073942197,100007139202402,100007146457032,100007339960523,100007389630991,100007415775563,100007427553825,100007429632916,100007468037530,100007506524990,100007586713467,100007843151986,100007867725012,100007892473252,100007929394619,100008005412355,100002444172740";
        WWW hs_post = new WWW(post_url);
        //yield return hs_post;
        float tempTime = 0;
        while (!hs_post.isDone && hs_post.error == null && tempTime < ServerConnectionTimeOut)
        {
            tempTime += Time.deltaTime;
            Debug.Log("tempTime...." + tempTime);
            yield return 0;
        }
        if (hs_post.error != null || tempTime >= ServerConnectionTimeOut)
        {
            Debug.LogError("LOI ROI");
        }
        else
        {
            Debug.Log("Text respone : " + hs_post.text);
        }
        Debug.Log("Dispose");
        hs_post.Dispose();
    }
}