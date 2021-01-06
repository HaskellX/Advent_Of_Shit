using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_5_1();
        }

        private static void Task_1_1()
        {
            var input = $@"1310
1960
1530
1453
1572
1355
1314
1543
1439
1280
1367
1368
1313
1423
1771
1868
1555
1635
1200
2009
1649
1824
1979
1523
1548
1415
1371
101
1836
1570
1494
1850
1624
1151
1408
1220
1372
1871
1712
1765
1950
1654
1797
1814
1592
1747
1566
1600
1445
1297
1374
1916
274
1735
1392
1977
1957
1672
249
1980
1791
1733
1962
1641
1487
1486
1741
1751
1309
1342
1567
1353
1909
1657
1837
1438
1510
1811
1939
1558
1215
2010
1891
1929
1208
1459
1272
1696
1820
1206
1414
1795
1884
1734
1745
421
1908
1986
1329
932
1468
1720
1769
1402
1913
1580
1707
1799
1185
1587
1521
1428
1210
1822
194
1973
2000
1940
1481
1509
1563
1697
1924
1671
1516
1758
1552
1996
2002
1883
1539
1089
1794
1337
1875
1736
1683
1682
1354
1846
1427
1359
1854
1574
1198
359
1859
1517
1706
1537
1915
1983
1482
1941
1703
1954
1597
1903
1991
53
1515
1259
1421
1384
1948
1776
1965
1625
1478
1629
1949
1144
1951
1656
1137
1349
1910
1483
1229
1480
1324
1664
1604
1764
1564
1673
1686
1841
1640
1627
1984
1258
1376
855
1413
1261
1429
1863
1540
692";

            List<int> numbers = input.Split('\n').Select(x => x.Trim()).Select(x => int.Parse(x)).ToList();
            List<(int, int)> tuples = new List<(int, int)>();

            foreach (var VARIABLE1 in numbers)
            {
                foreach (var VARIABLE2 in numbers)
                {
                    if (VARIABLE1 + VARIABLE2 == 2020)
                    {
                        tuples.Add((VARIABLE1, VARIABLE2));
                    }
                }
            }
            
            Console.ReadLine();
        }
        
        private static void Task_1_2()
        {
            var input = $@"1310
1960
1530
1453
1572
1355
1314
1543
1439
1280
1367
1368
1313
1423
1771
1868
1555
1635
1200
2009
1649
1824
1979
1523
1548
1415
1371
101
1836
1570
1494
1850
1624
1151
1408
1220
1372
1871
1712
1765
1950
1654
1797
1814
1592
1747
1566
1600
1445
1297
1374
1916
274
1735
1392
1977
1957
1672
249
1980
1791
1733
1962
1641
1487
1486
1741
1751
1309
1342
1567
1353
1909
1657
1837
1438
1510
1811
1939
1558
1215
2010
1891
1929
1208
1459
1272
1696
1820
1206
1414
1795
1884
1734
1745
421
1908
1986
1329
932
1468
1720
1769
1402
1913
1580
1707
1799
1185
1587
1521
1428
1210
1822
194
1973
2000
1940
1481
1509
1563
1697
1924
1671
1516
1758
1552
1996
2002
1883
1539
1089
1794
1337
1875
1736
1683
1682
1354
1846
1427
1359
1854
1574
1198
359
1859
1517
1706
1537
1915
1983
1482
1941
1703
1954
1597
1903
1991
53
1515
1259
1421
1384
1948
1776
1965
1625
1478
1629
1949
1144
1951
1656
1137
1349
1910
1483
1229
1480
1324
1664
1604
1764
1564
1673
1686
1841
1640
1627
1984
1258
1376
855
1413
1261
1429
1863
1540
692";

            List<int> numbers = input.Split('\n').Select(x => x.Trim()).Select(x => int.Parse(x)).ToList();
            List<(int, int,int)> tuples = new List<(int, int,int)>();

            foreach (var VARIABLE1 in numbers)
            {
                foreach (var VARIABLE2 in numbers)
                {
                    foreach (var VARIABLE3 in numbers)
                    {
                          if (VARIABLE1 + VARIABLE2 + VARIABLE3 == 2020)
                          {
                              tuples.Add((VARIABLE1, VARIABLE2, VARIABLE3));
                          }                  
                    }
                }
            }
            
            Console.ReadLine();
        }

        private static void Task_2_1()
        {
            var input = $@"8-9 n: nnnnnnnnn
14-15 d: dzjgbdwdkdhdddh
16-17 m: mmmmmmmmmxmmmmwmm
7-17 d: pmgdhpqbqdhshgtjt
1-2 b: mvmgzbmfbrcnr
16-17 c: cccccccccccqcccgcc
1-6 x: ctqxsh
1-5 l: lllvw
9-10 k: kkkkkkklrsnk
7-9 g: xsgzggbglgtm
3-4 b: brwb
4-5 x: xdxlfx
5-6 c: cccccc
4-7 v: vvvvvdpx
2-7 s: qwdngzbtsntgzmxz
6-8 s: ssssssssssss
2-3 t: tjcttt
2-4 z: nbgfl
11-12 z: gnjzwzwzzwcbhv
4-5 v: tvkfvnvvvvcv
1-3 h: hhbhh
15-16 g: gggggggggggggggv
6-9 t: ftjztttfnztv
2-5 v: vxpmqvvzvnglvvv
2-4 r: rsxq
3-4 k: kxkk
2-3 k: kkkk
3-6 t: ktttztt
1-2 v: zvcvv
14-16 b: bbbbbbbbbbbbbrbb
7-10 b: sgmbgmxbxnpjgpthcbr
5-13 r: wmfmgmxxwgbrpllfqnjj
3-4 t: ftcd
2-3 z: szzf
1-6 j: cxjjbj
2-3 t: ttvt
2-6 h: hhkszjhjjxhqhrhn
3-4 s: ssns
4-8 x: xcjmwxxxlrqxxfx
3-10 g: ggvggggkgrggggggxg
2-6 z: lzmhmvftsvcjfhfw
9-14 x: xxxxxxxxhxxxxxxxxx
8-16 d: dddddddddfdddddtd
1-2 g: wrhg
2-7 r: krjrxmrrvhzrprr
11-18 v: vvwvdwslcxvtkzvvkr
9-10 m: mmmxfmmmmmmmmmmz
7-12 g: ggktlgggsqpgw
6-8 t: tttttbtpz
8-18 h: nfhhwkthhxhhcshhwh
10-16 c: smnclksccmnmcmzcc
14-15 f: nmndkphffnqmffj
4-10 f: ffcwqvfffffvfg
6-13 v: vvnvvcvxwxfvvvvvvvv
1-4 k: qklkkkspwkxfk
7-9 w: wwwwwwwwk
9-10 c: ccccccccbpc
11-14 r: qrxrjbbtrxrrrr
2-5 j: wckjjdjjjzvhsqr
10-12 x: xxxxxxxxxcxxx
3-8 l: vnlslkhlwdd
4-12 n: nxnfnqnnzmngnn
4-5 z: zzgpzzc
4-5 z: zgmtbz
2-3 v: vkvv
11-12 q: mqrqmlfqqqqlq
6-14 g: lggzggfxggsggqggxg
3-8 q: sqzqrbgvzp
6-7 l: lllklll
5-7 c: czrccvcclm
11-17 r: rrwrrrrrrdrrrrrrbrrr
2-4 x: xsxx
3-9 l: llllllllwl
3-19 c: ccccccccjccccvczcccc
5-6 h: zhvhhhhghb
1-3 t: ttttvttwt
1-5 p: ppppppp
3-4 g: ssvgr
5-6 t: ndjbtttnmf
14-16 f: fwptdqwwpztqhfnswts
1-2 h: ffvmvbhmh
2-3 f: gdrz
1-2 l: slll
3-5 w: zwwwrwwwwwwww
1-3 w: fszt
8-9 j: jjjjjjjjrj
4-9 k: kkkskkkkkkk
4-9 p: sppzppqpplpp
2-9 s: ssvxrrjhs
11-14 v: cvvvvvvvkvvvvvmv
1-10 q: qqqcmqfjqs
3-7 z: sgzzfzkzz
5-8 w: wwwwhwrztw
3-10 p: phbbmpzhpppspdfr
2-8 c: cscpcccg
2-4 r: rsvr
14-16 h: hhhhhhhhhhhhhhhh
1-13 j: jjjjjjjjhjxjxjjjj
7-8 v: vvvvvvvvv
4-8 r: vbhlmwrrvmkrwn
3-4 c: ccdc
3-5 h: hbjxx
3-4 q: qqdqq
10-14 k: dkkwnrkkhkwzhkkkk
1-3 z: zzzzzzm
3-7 t: tbtxfttvw
6-18 n: qntgnnnztkhwtnjrnm
4-5 g: gggrng
2-7 c: bclzgcgq
1-8 j: jbjjjjjj
2-3 x: jxxfbtxskxc
5-7 g: kgszqgcgxgqtppgb
1-6 l: llllltll
3-4 g: brgm
12-16 x: xsxxxxqpxxvxmxjxxx
6-7 k: kkkkkkk
3-9 f: fftbvjfvfffstzfff
14-15 r: khlwrfrcnrkddrh
2-4 h: hwhqm
4-5 z: zzzzd
7-10 b: bbbbbbpbbt
8-10 h: hhhhhhhdhn
5-6 c: bccclt
7-11 p: pppppppppppp
4-6 r: rwrrrrrr
9-17 m: mmmmmmmmmmmmmmmmmmm
3-9 n: nnnfnnnnjnn
3-4 q: rqqcq
1-2 z: mbzz
1-6 h: hhhhhs
10-11 h: whhhrvtghhh
5-6 g: ggggjz
5-8 g: gggbgggvg
15-16 v: vvvvvvvvvvvrvvtv
5-7 q: qwrzqbllqqqrgkqnlsr
2-4 c: ccccc
7-14 p: spppxpppphblprm
4-9 j: qzxlxdzsdlnlhw
2-4 l: lzphl
16-17 g: ggggggsgggggggxpqggs
3-17 d: ddddddddddddldddcddd
10-12 n: qtkgqxknvjnnsbnrwtp
8-13 d: dddddddcddsdkdd
7-16 v: wkntvjdvvwvfvnqvm
2-5 w: vwhjw
2-3 f: dmgff
2-5 p: nklmmzp
4-5 x: vxxxxd
1-2 m: mmmqm
9-12 r: rrrrrrrrqrrm
6-9 r: ldvhvrjdkqhmr
2-9 f: fmkffptffzdgk
5-12 x: xxxxxxxxxxxbxxxxx
3-4 w: bwwqgwt
10-11 f: fffffffffhfff
10-13 n: nnfnmnhnnnnnmn
12-13 n: nnnnnnnnnnnnnn
8-13 z: rzzfbzzdrzlkn
13-14 p: qgkxppfppfjcnx
3-4 z: bcxdctzg
3-9 z: zznzwzzmffqxj
1-2 n: nnnznr
2-6 s: mtspsskswf
2-15 g: ggggggggggggggqg
3-8 x: tzxqfjrkpdgkxptbxm
15-19 v: dvcvvvvvvvvvlvqvvvv
4-9 r: dszrbrbzrwlfxpcrkn
6-7 f: fffffsmf
5-8 v: vdvvvvrv
10-11 m: mmmmrmmmmmhmmm
9-12 s: stwssszcsssr
8-15 j: jjbjjjjjjjjjjhj
6-8 v: vvvvvhvv
1-7 w: ghxwddwwbfchvtff
6-9 v: vvtxxrbqpvdvvv
3-5 q: fqfqrskl
15-17 k: kkkkzkkkkvbkkksrlkkk
2-18 w: rtfwsrwcbpwtwjzmwwws
5-7 f: pfshgsnff
8-20 h: jkkhhhssfppkjqdfdhtp
2-7 b: bblqbfhbbbb
3-6 j: wjmjjxjj
4-13 d: dfzdkqpddgchbhtgg
4-7 x: xxxxtsn
5-6 m: mmmmmmtm
4-5 p: pkmppck
1-14 j: jpjjwjjkjjmxkjwqj
3-4 s: qxsfvs
8-9 k: kkkwkzxrvkkkk
13-15 r: qzrzrrbrxrcrzjpr
1-4 l: lmvlj
1-4 l: mrll
11-15 w: wqwwwnwwwwtwwfwwjww
8-9 g: fggzsggmggggccm
2-5 f: vggqfcffxh
2-4 c: cwcccr
11-12 c: ccccccccccfc
3-5 g: ggmggg
10-11 l: llllllllrll
5-6 v: wvdjvv
6-7 p: ppppphkp
7-10 c: tcccccnccjcccc
8-10 m: mmmrmmlgmt
3-14 j: ljsjjjjtjjjjjhj
10-16 c: kcjcccccccccnvtccccc
1-9 n: tnjnnnnnnnn
3-7 h: mhdpxhhh
15-16 c: ccccccgcccccccgcc
6-8 t: tvkddtrt
3-4 k: fkhjk
9-11 v: bqmhnjvpvxr
7-9 x: xxxxxxsxpx
16-17 h: hgjzqhvqhsgcplwmhvth
16-17 p: ppppppppppppppkqvp
8-11 l: lllllzlbclslt
4-18 k: kkkkkbkkkkkqkkkkkks
1-8 b: cxbvpxbzbsz
1-12 f: ffffffffffffffff
13-19 d: ddddddddddddkddddddd
9-11 v: mtvvvvvvhvgvv
10-11 t: tttttttttdtttt
5-9 g: gglgggpgdlgtcqg
7-10 m: mzmmmmmmrn
5-6 q: qqqqsq
8-11 f: ffrcfbfnwffzfpxfbvf
7-10 f: ffvfffxbpfffmjfqb
2-3 r: rrrr
6-7 x: bxxxxxgj
3-5 j: jljndr
4-14 q: qqqzqqqqqqpqqdqqqqqq
3-6 n: nnnnntnnn
15-16 g: ggggggggggggghggg
13-16 x: jxxzqxvxfhxxvggxdqx
4-6 f: zfxfkfhmsfgjf
9-12 r: rrrrrrrrgrrnrrrrv
3-7 w: wczsqxwdw
9-12 k: hxgkkklkkkkwkkk
1-4 s: sssns
5-6 v: vvdvlv
12-14 g: gsgggggggggggkgg
5-16 r: rlkqflvvtfcdckfrn
18-19 c: cfncccccccccccccclzc
4-8 n: nbntnnnvnnnnnn
3-6 l: jfpxllfrbll
4-14 k: xphrkstmqmqhkw
2-10 b: rrsrbbqvbr
5-7 k: wkbgkkkqfkkkk
5-6 k: kkkkkkk
7-10 k: mqrsjkksskswqz
11-14 x: kxxxxxcxxxnxpbdx
2-15 h: hhhhhhhhhhhhhhh
5-12 p: pppjpvgppppppppprv
2-11 l: lzlllllllpdlll
5-7 t: xwtzttvctqtpvbltpbtt
2-18 k: ckhhplvxfrdqkbjhbkpp
12-14 k: rkkqvkfngkkqjn
3-7 n: mtxnkbnw
3-11 z: zzzbzzzqzmzzczzzz
3-4 m: mmmq
2-7 s: ssssskcnssgnkzd
3-4 g: rmgrggd
2-3 h: grhrtpcch
2-6 d: dddddddv
3-7 g: jggggggggrfggggg
5-6 v: ljztvvqrcsjdnlwv
2-6 x: vxxtwk
2-8 v: vvvvvvvvjv
3-5 h: dwhwv
2-7 n: ttxgbdbwnnnvnnx
2-4 c: cctfcsb
16-17 c: ccccccccgcxckccxccc
5-6 x: xxxxxx
2-6 p: pwndpfrpppppppppppkp
1-4 h: zhhjlh
2-5 p: prpxwppljppvwjtppkp
2-6 j: bjjjjjjf
16-20 p: pmppppbpppppppppsdpn
1-3 b: bbbh
8-11 k: nkxskkbkfjvcjkdcgrk
7-12 c: cqcdcccgchnd
5-7 m: mmmmmmmmmmmmmmm
4-12 j: kjdjjvrjxsjw
7-16 c: dfzcsdcdgrxvfkjzccmw
1-12 m: mmmmmmmmmmmmmmmmzmm
1-2 s: sssws
1-5 x: xrtxs
3-4 w: wvwv
6-7 s: sssssss
11-12 m: lbwtvjjmmggm
16-17 l: llllllllllllwllht
11-13 t: qtttttgtttttdmt
2-5 r: ldgrf
13-18 r: rrrrrrrrrrrrrrrprr
12-19 l: lnfnhllrjgcllhjlczl
6-7 c: clccccv
9-14 b: shlfbcxhbbmbbzbg
4-6 s: sjssvxdx
11-12 v: vvvvjppqkvqv
5-7 j: jjjjmjjjj
8-11 l: dsldfrdvbll
3-4 p: pkvmcps
2-3 s: ssss
8-11 j: txbxnpwqxjm
4-6 d: drdvdd
4-8 v: xgwkxvfq
1-5 t: zttttttttqmtt
5-8 c: ccjccccqc
9-18 z: zzzzzzzzzzzzzzzmsgzz
1-4 q: qqqkq
10-11 w: wwwwwwwwwwww
5-9 r: prtdrksjbmzmrq
1-3 v: bvvnsmrdgxmnxjjv
6-11 d: drnkdpvdvhfrfgzkn
5-9 h: khhrhhhtvhtznhf
1-3 g: gfpgn
4-5 p: pppfg
8-19 n: nnnnnnnrnnnnnnnnnnzn
6-13 c: cztfcwpjcczsc
3-4 r: rrrg
4-6 t: tfjvtv
4-7 g: nggggggg
2-3 c: cmkc
7-15 r: jrrrrrrrrrrrrrwtrrqr
8-12 h: hjtpfjpbbzwhw
7-8 d: jddddddd
1-9 s: lsssssssmss
18-19 m: mmmmmlmkmmtdwmmmmmh
5-9 t: ttzstqtmt
7-11 x: xxxwxxxxkxxxxgfxxx
2-3 s: dssjzpsxjr
3-4 g: gcgtg
3-4 f: ffxff
9-11 v: tvvvvvfslvvfvv
1-7 n: nmlfmnz
5-6 q: gqzqtqlq
4-5 v: pvvvczdtwthvc
1-3 z: zzrd
6-7 b: sbbmbnbbrp
3-7 l: lkllvqplww
7-9 s: sssssssss
1-8 g: gggkvggsgg
5-6 n: nhnplpl
2-9 g: vgnfzjfvjmmtgd
1-4 d: dcddddddqdh
1-9 z: zzzzzzzzzz
8-10 q: wqhcwqdqqq
7-18 z: tfrfdpwpphzplxfbnw
7-10 f: rffnjdnffmfffrzfqgz
6-7 p: pppppppp
2-13 n: cndfbtxgqzmtnmq
14-19 v: vvvbvvvvvpvvvsvvvvvv
8-11 b: bbblbtwbbbbbb
3-5 v: rfvvv
15-17 n: snmnnnnnwnnnnnnnnnn
4-12 q: sqqqhwnbqqxqbvfrk
4-6 l: lllllvl
17-18 c: cccccccccccccccccc
1-12 t: gttttttxnttzttt
16-17 t: kfmtctsqttztmsxtf
7-14 f: ffffffcjffcfjfff
5-19 b: jtvbbbrbbbjbcsbbvvb
7-8 g: gggggggk
2-4 w: dwvwww
1-3 r: rrrrrrm
7-8 q: qqcqqqqq
6-9 m: tvglftcxmmnshcvscp
3-6 m: cmgmmdmm
6-9 k: kkkdkwzkgk
2-15 w: bwqwwhpwvfpdwdvjwvk
7-8 h: jdhhnhrdghh
3-6 l: llxllpl
4-11 q: ggrjmwhrqdc
7-8 w: cwcwwwwwww
5-6 s: sssssls
6-9 w: rwjwjwwww
1-8 c: ccncccccccccc
2-4 b: xkbbf
6-9 t: ttttttttrt
14-15 h: hbhhhhhhhhhhhhw
14-17 t: ttttgtttdttttttttt
4-7 q: gqmqrqr
9-11 j: tjjjsjwjglpjjjkjjg
18-19 j: jjjjjjjjjjjjjjjjjjf
15-17 p: ppppvhppppppppppp
3-5 d: jlqcqdnprnddpd
6-8 n: nnnnnnnn
5-7 h: cwhhthhhv
3-5 z: wqzmzpbjstzjpfww
2-9 c: fkthkshccccczcph
11-12 c: hcsscmqcdcgp
8-9 t: tttttttkq
3-4 m: tnmcvtljnpdphg
11-19 l: wqjvlvzrgxlvrngwlktj
6-14 s: dxzsssssmzgsmssss
4-7 c: ccckjchc
8-9 s: ssssssrslsm
16-17 b: bxbbbbbbbbbbbbbbz
3-12 p: mpnpplpkppmbp
14-15 v: vvvvvvvvvvvvtvv
5-6 d: kttkndlslhfg
3-5 w: tlwwl
3-4 n: wnhn
13-14 r: zrbmrrrrrrrrmrrr
3-5 f: fzwgrmzpkcfqkftmz
5-6 s: ssssss
5-7 h: wxpzhhzgwhdxqhmhw
8-12 j: djsgjqjjjjjdj
13-15 h: hhhrhhlhhpjhhhr
6-7 v: vwvmvhw
1-9 k: dmwkkkkzk
1-2 g: ggtkbgvgtvggx
10-18 r: rrrrrrrrpkhrrrrrrxrs
5-10 n: nxbslftnwpnn
4-5 d: ddhdd
12-15 l: lllllllllllllhlll
2-3 m: mmmmmmmmmmmmmmm
1-8 s: ssshsspm
3-5 b: nblhbdbbb
2-4 t: qtjtctndq
2-14 v: vcvkvvttxvkvpvhvvd
12-16 g: gqckxjtggwzgtlqrtjkf
3-10 s: ssvssssrsssbss
2-4 n: knln
4-10 f: xfqlfffbflm
1-3 s: mssshjgshpfrssrss
4-5 t: nttbj
2-13 w: lwqwmwhthzrtwkgp
1-3 r: jrnqb
3-13 k: khkkkvkkfkkqkkhfwzf
4-8 g: gggwgggg
3-4 g: wgjgxhngdt
7-9 k: mgshkgnhkpkjsmkvjp
7-9 d: gdjrfqndcdhddmdhdd
17-18 g: gnggggggggggggggng
14-15 g: ggrgggggggggggg
2-7 x: sxpwxddpxnxtxft
5-6 r: grdvrrrrrwrrrrrgvq
4-5 f: ffffff
8-9 f: fffxffzgff
12-15 f: dfffffffpffgffjlfmvf
10-14 l: dlflltmllplljllvlzll
1-2 j: jtnftndqklxzj
1-5 d: ddjwrdddddddhdddddz
13-14 j: lgztjqgjfbjfxff
5-7 k: kkklqkz
15-18 m: hwvmmpmmpqwsmrwmmmsm
5-6 h: hlvhhhqhlh
2-4 j: jjldjjjx
10-11 f: ffffffffffffff
15-16 t: ttttttttttttmtjttt
3-4 v: vvvv
8-9 n: nndhnclnnnnnrwnn
5-6 r: rxrrrrfrr
4-18 p: vwmppgpzltpplvwvpg
9-10 z: fzzzzzzzrzzz
4-6 n: nnbnvnnn
10-11 x: xxgxxxwxxfrwk
3-14 v: tqvvvjvdvvvzkvvvvv
11-13 z: zzmzzzzhrzrzzzzzp
5-6 s: ssgwsvssqs
2-5 z: zbzfzzds
2-5 s: sssss
1-18 r: rrrrlrrrrrgrrrrgrr
2-3 v: vgvvvvv
3-13 c: qdcvfvkjtczgb
3-9 h: hvhhhhhshh
12-13 x: xdxxxxxxxxxxxx
3-17 q: qqqqqqqqqqqqqqqqcq
12-14 q: khnjqkkxlzpqhqj
14-17 t: tttttttttttttsttpt
15-16 d: kwpdfkbhcdhkwsdh
2-15 m: fmdvntdqklcvmhmqjl
5-7 q: qqqqvqnqqq
3-4 j: mnjjj
4-15 f: lfbffxfpffsfbdfhpfs
8-9 s: sssssssgr
12-14 b: bbbbbbbbbrsbbnbb
2-3 x: xbxpvc
10-14 v: vvvvvvvvvvvvvx
6-13 f: kfvfcfffvfhdn
4-16 k: gnzkfdkmrjvwdjgkf
2-5 l: lljll
2-4 r: dprr
1-20 v: vvvvvhvvvvvvvvvvvvvc
1-2 l: mlzljlvllkpzll
4-13 r: kbzrzdrmdvfcl
6-7 v: vvpvvzvv
6-16 h: dxfwghscmjgfqmmf
6-9 h: hhthhfhhdh
6-10 j: bvqrjjjfdtjjjjj
4-7 k: gklkcrvvkk
2-8 k: ndtdhjpb
13-15 f: ffffffffffffffb
6-7 m: mmmmmmzm
2-15 g: xbgxgfgftvgvgmcgnxc
4-8 q: xkrqvqqq
4-9 v: vvvvvvvtbv
8-16 w: wwwxwxwbbwwwtdww
8-11 h: hdhhhhhcght
3-4 f: ffsb
12-13 h: hhhhghhhdmpfhh
6-7 f: ffdmgfh
1-2 c: pcsc
4-6 q: lkzqqmqqq
3-4 b: bbjg
3-6 f: lmbzffl
10-15 p: prxpdpwqpwplpppp
10-12 p: pppppppppppfp
7-8 m: mmmmmmmjmq
5-8 j: jjjfjbjtjj
8-10 t: tttttttmtm
5-11 k: kkkrhkkkkkk
2-3 c: jcccwcbwfrckb
3-10 n: qnnnnnfnnknnnnfnxn
12-13 h: hhhhhhhhhhlhh
9-10 s: smspmjsssss
6-7 d: dddddmdnd
9-10 g: kpnbgstjjgtbhk
9-13 s: ssssssmshsbsxss
1-2 s: lsfsss
8-9 n: nnnnngnnn
9-10 s: sssfssnssssjs
6-8 m: mmxmmmmmm
4-6 x: xtxjxx
8-11 r: qrqkrwbfjln
9-10 h: hfhhhhhhvq
6-10 k: kpkpkjkkkvk
7-10 b: bbbbhbkmmgbvk
8-10 k: kkkkkkkkplvmmk
1-2 r: rrwr
2-5 d: tdddrddgq
7-9 j: jjjjjjjjfj
15-17 m: mmmmmmmmmmmmmmmmj
5-6 v: vvcvvvfwjvvtn
14-18 t: kznfxrrtfcdntttjrt
3-4 c: cjdcc
17-19 q: qqqqqqqqqqqqqqqqfqh
4-5 k: fzvkk
3-7 p: pgppppppppfpp
10-11 k: kkkkkkvkkkz
6-7 t: tttjcttt
2-4 w: kwlcwbgfwwtqpngnb
4-5 q: kqqvlq
16-17 q: qqqqsbqqqqqqqqqbqq
19-20 q: lndjjddqcqkcjztwfxvw
4-6 p: pppmdccpp
13-15 x: xxxxxxxxxxxxhxw
1-9 d: lmdsdfbjpkmh
8-15 v: vthvwvjvcvvqvvhmvs
6-7 r: qxrrrrpr
3-6 n: cxzxnn
9-11 l: lllbhllhllbll
5-9 d: nbsqdctdkp
1-10 l: lllllllllflllllll
1-5 f: cdsfqzwfnjkhdj
2-5 m: clmgsmmdz
1-6 g: cbqgngzvjpxjbwnlprq
6-8 l: bfxrllllllw
6-9 v: qtcxqvmvvdptxvv
3-4 p: fjqx
5-8 t: tpnttxtlt
5-6 p: pppppf
12-13 q: qqqlqqqqqqqqw
5-6 g: hgggvx
1-2 x: qxxx
6-8 n: nkjnnpnnn
6-8 j: jjjjjjjfjjjjjjjj
4-5 s: sbsjm
2-6 m: lmtmlm
3-6 c: bzvhcccncz
3-5 l: lllglnlmpl
2-9 p: hpbwppwdrlpfwbdkmj
7-10 l: tlzwhnlrkrc
4-6 m: xmmmqdmcl
1-6 d: jkdmmd
5-7 c: cjqlhcdcc
4-10 z: xgtznmnznkzvz
13-15 z: zzzzzzzchzzzqzzzz
2-5 q: qhvqqz
1-9 l: nlllllllzlllllllll
4-5 q: qqqzh
5-7 t: ttpttdt
3-11 l: lmnxlthlmlzksggzll
2-5 q: qprnq
16-18 b: bbbbbbbbbbbhbbbtbgn
3-4 l: rlhl
8-9 n: nwdfntdnsnmzkqthl
6-8 h: hhhhhthv
1-2 x: xcxp
7-11 t: nttttctzxmtt
2-4 b: ksvb
17-18 d: dddddddddddddddpqd
3-5 x: lprxzdhxxvz
7-8 z: zgzzzzlzz
2-3 p: rcpxw
11-17 k: qkkkkkkkthkkkkkmkkk
4-6 s: ssrssswxsssmsk
5-8 d: ddddddddddd
5-17 v: vvtvvvtvdvvvvvvvmcw
3-8 r: rhvfrfcr
12-15 z: zzzzzzzzzzzpzzpzz
7-8 p: jppppvpp
13-18 d: dvdnddddddddgddsdd
10-11 q: hqnqvdpqdqqkq
2-4 x: jcxxl
6-7 q: qqfhfqjqr
10-11 w: kwpwwhwnwwwwwww
3-17 d: dddddddkddhdddddd
4-6 s: ssnhswswlsc
14-17 j: jhjjjrzjjmjfpzjjjjj
1-9 z: ztzhzwzzkdzzr
7-14 s: dcspnghrssxsss
5-12 w: ctbvvxzwbwgqw
7-9 k: kwkkqkkkgkm
11-15 l: gllclqplllrlnlpzllc
15-16 p: hpbpppppjpppppppppp
3-5 k: cklnfv
5-7 t: jczctqm
14-17 j: jjjjjhjjjjjjjsjjjj
9-10 g: gsknxggrgblfprf
5-6 m: zjmmqrflmfpmswcvvmtl
8-9 d: dxdddddds
16-20 w: wwwwwwwwwwwwwwwdwwww
5-7 s: ssssnsbs
5-8 z: bzbgzvzz
2-5 b: wbpkbbnkhcndh
11-13 r: rrrrrrrrrrkrsr
12-17 c: ksffzpccccspsqvjc
2-20 v: vvvtvjvjvvvvvvvvstvv
3-4 z: tzszjqzz
3-12 x: scpxgxqrtxxpjxn
13-16 w: wwwwnwjnzwwwwwwwwwwr
9-12 l: zxlrflvclgck
2-8 s: klsnwsdzbss
5-9 s: ssssssssns
1-9 q: fqqqqqqqqqqqqqqq
15-17 n: jknfnsvntjqglbnxn
15-16 h: gbpdwhhhhlthrjhh
5-7 w: cjwgkxdwwxl
1-5 j: jmnczjrlqchdwpthbjst
6-8 v: vvvfxkvvvv
5-8 g: ggbgqggmhg
3-15 v: vxvvfzvvwcxvjvvqvvq
6-14 h: drppknzrchcjhh
2-3 n: dgntnq
9-14 s: ssssssssxmsssxssssss
2-4 j: wjrdcjz
5-12 n: dntnnvbfjnznn
3-4 z: zzmnzbsrt
6-9 n: kngngnnbcnhp
6-13 k: tmsskkjkkvtksnm
2-4 w: rwhf
6-7 p: ppppppwdpvp
2-8 r: prqvprbrvrsjxm
1-8 f: gffffffff
6-8 b: lbmtblbptbxfdqb
4-10 r: rrsrrrnrrbmrngrk
10-17 b: bbbbbbbbbmbbbbjbhbb
2-13 v: tmvqcvvwvvqvzvdx
13-19 d: hrtlzplwdkshdbsjmsd
6-13 w: wwwwwwwwwwwwdw
14-16 q: hlkhpvdqrkhkqlhhlg
7-8 m: mmmmmmmx
11-12 p: pppfnpqppppp
4-5 k: kkclzkfk
8-9 k: krkkdkkkk
15-16 w: wwxwwwcwwwwwwwjw
12-16 w: wwwtmwnwqdwvjpwzwwz
5-9 d: wdddrdddrdkdkddd
5-6 p: qppbpvp
1-7 t: fgznlbtgwtnrlhgf
4-10 j: jjjjjjjjjljjj
3-6 z: spgznzcz
11-12 h: xhhhkfhhhhmh
3-12 g: ckgvgbrgcqrggggt
1-6 k: kkkkkjk
2-3 j: qzbf
3-4 r: rrlprrrrrrrrdrrrrr
13-19 l: llllllpllllllllllll
6-10 x: xxxxxjxxxxnx
2-12 f: jffffbffqftf
5-8 b: wbgbgbsb
4-8 t: jflltrxfgttqvrgt
2-5 z: fzzzszcwzz
3-6 w: whwwbnw
12-15 n: nndnnsnnnttnnnnnnn
4-9 c: mcsstwccc
3-4 q: dxwq
6-11 v: swmrlccvxzdrffvvwj
10-11 x: xxmxxxxxxmx
1-2 k: fkqk
15-16 d: nlnzddfrjqvdjwddmw
2-6 k: ldkdmnmcp
1-11 p: fptzpgpzfhp
12-14 b: bbbbbbbbbbtbbx
6-12 w: wwwpbwwmxwxz
1-4 r: mrrrrrr
13-18 w: wwrwgwrlwwwwwwwwwlw
16-19 z: szzzjzzmzzzzzzzzzzsc
2-7 v: qvvcsvd
7-10 s: mtskmnvnlcgsb
6-7 q: mkdqqqq
3-5 x: xwxmx
7-9 q: qsqjfqcqwnq
1-4 r: crcb
14-18 k: lfwklgqjzgxfpkpkfqr
9-14 j: jjjjjrjzjjjjjfj
5-6 x: xxxxxxh
1-17 z: gvczzzzqdqzzzzzmwkzd
11-14 k: dkkklkkpkkkktkkkkkk
9-12 j: jjjjjjjjqjjv
2-6 d: dthddmddd
4-5 v: qvfjfvvdlszqxvbl
4-5 n: nnndn
7-8 c: wqnmpcwf
1-10 c: cvgmnkcssrhqccmddgh
8-9 m: lmmtmxmsm
3-6 v: qvvnqvvrfhv
6-7 x: vxxxxmkjxxxxxxxxxxx
5-14 x: qxjgbxxxxprxxn
13-14 p: dphsqvhrfsbpqpp
3-5 r: trvrrxrrr
2-5 f: fffff
2-6 w: whwdwnwt
2-3 x: wxcsxx
10-14 p: pswtzbkslpqppph
3-5 l: zllllx
9-11 g: ggggggggggxgg
4-6 h: fvhhfhhfjqffhhhwx
7-8 t: wttttttf
11-14 q: qqqqvqqxzcqpqhqkpqtf
5-9 b: bsrbbbxkm
13-15 t: tttttkwtttttgttwt
4-7 c: czccvxtc
9-10 n: nwnnnnnnnn
3-5 f: ffdtf
13-14 h: hhzhhhhhhhzhphh
9-11 g: kgsfsnhsggglgsp
5-6 s: hbxpnsssvx
10-11 t: ltsrtmvmkgm
12-18 k: xlwkkkkktkkkbkkrjxkk
5-7 l: lnllwlw
16-17 k: kkkkkkklkpkkkkkknkk
11-12 t: ttttttttttttt
11-13 v: vvvvvvvgvvvvvvv
10-14 d: ddvddjdddkdddd
3-4 r: nrdrhnr
1-4 q: pqqxcsws
5-6 p: ppppjpp
14-15 b: bmbflqmbzhkbqvb
9-11 t: ttntttttnpt
15-16 l: llsllldflhblwlllf
5-10 w: swwwwnwncwtfrpnw
6-7 j: jjjjjthb
2-4 d: ddhdzfdddlp
2-9 q: jqqqqbqqqzq
19-20 b: bbbgbdbkbbhbsdpbbtbh
7-9 v: hvvvxvvvv
6-7 l: gsbslll
2-6 p: pzpppwpppppppppp
10-11 g: kmkngxnnrfh
1-11 v: rvdvvvvvvvv
2-4 n: nhndnnnnqn
12-13 q: qqqqqqqqqqqqm
7-9 s: ssssxsnsssss
2-15 t: ftntkfmqxzxggcfwb
1-7 v: vvwvvvqdvv
6-14 s: sbsssdssssssfqsss
3-8 w: vwwqwwww
6-10 z: zzzzzzczkzzz
5-8 b: bbvdmxqbbbbbbbbdv
4-8 s: stvsssszcswszs
12-13 x: xxxxxxxxxxxxxx
5-15 d: ngzjdxddjddxvbwzbd
1-10 s: ssssssssss
10-14 r: rnhrrrrrrrznrrr
1-7 z: nvzzzcvzzmzhnprzkz
2-9 w: zfmxnmltsbxpfsh
13-14 l: lllllblllllldgl
3-9 b: dbbrkmmfsmhblqb
1-6 t: tjmrctqggzdgtz
1-14 m: bmmmmmmmmmmmmmmmmmm
3-4 b: mwbndzbjp
9-11 n: nnnnnnccmnb
5-11 b: kpcbqbbbcmbkb
3-6 j: wpjjspjw
6-12 p: pppppppppppdppp
1-4 c: rccc
3-9 l: llllxllbllll
6-14 w: tlpcwxwwwzbtwd
3-4 q: qqqg
3-5 x: htxcvqkwx
15-17 r: rrrrrrrrrwxrrrrrr
8-10 k: kkkkkrkwkkw
3-4 s: jjwhksqrbxs
3-4 g: gvggg
11-13 t: tjgttvtdtbttttttqttr
5-6 j: jjjjmjjj
9-13 f: fffffffflffff
13-14 z: ccbzvzwmzpzzmz
6-7 b: bbjtbbbbbb
3-5 k: pkknmv
3-4 w: wmchw
4-7 b: bbbgbbbbb
10-13 q: qrqqqvxbplqqxqqqmqq
1-8 b: rbbbbbbjbbbcqbb
7-17 q: xqqqqqqqqqqqqqqtq
4-6 k: kqkkbbg
6-14 l: lglhbvslmhqjnw
4-6 w: pwwxxn
12-16 q: tvtqvcchgtmqqznb
8-14 q: hkthhbpjvkpxgq
11-13 m: smmffkhhkrmwnbwrs
8-11 d: dddddddddddd
4-6 m: lmdmmkwmmmfbs
12-20 w: wwwwwwwwwwwbwwwwwwsb
5-7 m: mrnhmplhwczr
7-11 p: pppppdbpppvpc
4-10 p: zpwsppfppj
3-12 d: dddddpfddrdln
8-9 g: chfcgzfgg
5-6 g: gggghg
7-8 q: hqqqxqqqqqqqqqg
4-10 c: cdtpvcccvd
7-8 s: sqwtsxsssss
5-11 v: pcvvrvxvvnpjn
4-6 z: hzmnzg
4-6 b: bslbbbxbbwml
16-18 z: zzzzzzzzzzzzzzzzzg
1-3 h: hhkh
2-4 r: wrtrb
5-6 d: ddddpd
4-7 k: kkkkkkkkkxk
8-13 k: pkkkkkkkkkgkkd
8-13 p: lpxppxpbpgppzppmppp
3-9 m: mmmmmmmmmmmmmm
6-7 h: cpmmhcttgx
11-15 b: bbbbbbqbpkfbbzh
4-7 j: jjqvjjj
6-8 c: gwrfrslcsqmcttzcl
11-13 r: mrrrrrpgrrnrrrr
3-8 q: tqqqqqqz
2-4 f: mtsxj
1-17 g: cgggggsgggdgcgrxg
1-9 m: mhgqjqxjnpmmmgnmfpm
2-4 g: rggbc
2-4 w: wgfw
7-9 d: qdmddddddmxdd
12-13 t: ttmjznwtwtttz
11-12 b: kjbkbgdbwbmcb
4-5 h: mhvhh
4-6 t: ttvttttt
9-12 r: zwlljhfrrfrr
3-4 j: jjjj
2-7 v: vvvvvvmvv
9-19 n: nnnnnnnnmnnnnnnnnnqn
1-3 q: qfflx
8-10 k: kkkkkkknkk
4-9 k: kvrspqfkkqj
14-15 b: bbbbbbbbbbbbbbbb
3-8 d: qrdsfdwd
5-8 j: jjxmrtjjjjkpnnjt
14-15 f: fnlnbzqffrrnffgf
1-4 f: fnff
4-5 x: xxxtx
5-6 q: qtqqlmqqq
14-15 f: fflffdfffffffkjfff
1-5 k: kkqkvkk
5-9 b: nbjtwbbgw
13-19 v: ssjjggrvrnbpvjlggsf
8-10 x: xxxxmxxxxx
4-5 d: vdwhtcsc
1-7 l: zlllllglll
2-5 d: drjpdwrlnpfqqrnlh
12-13 p: fthsszdpjcqxd
14-17 z: zzczzzzzzzzzzzzznzz
6-11 m: hhcsqmvmfgmkmbm
7-8 m: hmmmmmcmm
6-7 l: lllllgl
5-10 t: tttktdzttlcttv
6-12 m: nmmmpmmmxtmmjmxm
4-5 q: qnqnnqqqqqqq
1-4 c: zkpcc
5-6 n: nbphjnfn
6-7 f: ffffxqrf
1-6 g: lgggggggg
5-11 p: mbfpppplhdp
5-8 z: jzvzzkzm
5-7 l: llllllll
5-14 x: gvjvwmhxtzpsfxb
4-13 x: tvlfjxmpfrmqmkhrdlbl
8-11 b: nbbbbrcbbbb
8-10 w: ccccwwgwwwwl
2-13 p: wwwxrsfztddwplfpqx
17-18 c: ccccccccvccccccccj
11-13 d: dphdtwhqwdhmx
15-17 c: ccccccccwcccccccdc
3-4 d: ggjv
3-4 b: bbqbbqbx
2-3 g: qggg
10-18 w: wpbbfmdzhsnbcdxqrh
13-20 v: vpvvvvvvrvvvvsvvvvxv
16-17 w: vwwqhwwwfhwgdkhfw
16-19 b: bbbbbbbbbzpbbkbkbbjb
11-16 x: hczxsbkhxfbtxvzx
10-17 b: bbbbbbbbbsbbbbbbvbb
2-3 p: pppxsznnn
2-7 g: ggggsgggl
15-17 t: tttttttthttttttttttt
7-17 f: fffsfftfffffffffffqf
3-7 k: gpfmqbkqmkkkrpkpk
4-7 j: xpbgxjw
14-15 f: ffffftknfklfdff
1-4 k: pkkslkkkkk
4-7 w: czbwgqtpwztxwwbwmqf
1-5 n: tnnnnn
1-5 q: qdqtq
10-15 c: fccqccrkcccczcmcc
9-14 h: hhbbhhhhdhhhhhdhhh
2-6 f: fsbfdcvffhffm
12-15 h: jhhhhhhhhhhhhhs
9-11 p: ppppppppppbp
15-16 d: txdbddddjdsdbrvddddp
5-6 w: wqkwrv
2-4 z: zzjnsjspkgdkmvvlh
13-14 z: zzbzzzzzzzkzzzz
9-10 v: vvvvvvvvvcv
13-15 g: gggggggggpqgtgv
1-17 j: bjjjjjjgjjjjjjjjjjj
5-7 x: dpsxxxx
17-20 d: ddvxddtdhdrddjddnddd
5-6 f: ffxffp
12-14 w: wwwwwgwwwwwwwq
8-13 t: rnthvkbtnxvltsjn
4-5 q: qqqdq
4-12 s: ssssssssssszs
3-4 s: sssw
2-5 x: kzxwxqljv
1-3 x: rhxxdxxxdg
11-12 t: tthtstttgztrt
1-4 n: qzdnkpkrzgxdztdcfn
12-15 g: fgdzsqwkfdhrbsjz
1-3 g: kggg
6-9 c: hcwcccpcccwcck
8-9 r: rqrlrggwrrjfzgkmrq
4-5 r: ghzlrrrgs
9-11 g: ggggggdggggr
12-14 f: fffffffffffcffffff
3-7 z: mgzmpjz
1-6 h: hhzzbm
18-19 g: ggfhhvggffkqfgjnggg
1-8 p: ppppppphwppwr
13-15 l: qmjnjfnnlmbqgllwhk
5-13 z: zgpwzhwnmptrzrq
3-4 v: xnvnqjjrvvlgv
14-15 p: pppgpphppppppwpnrpr
9-13 h: hxfhhshbqhnhhp
5-6 w: wkvqbtbtfmsbwkwwhdwb
1-3 x: shxxx
1-2 v: vhvt
5-8 c: zdrlnhcctcpccsntl
12-19 x: xxxxppxxxmfglxfxmxg
3-4 v: vfqwq
8-9 f: fffffffxx
11-14 l: lslvlnbsjlbllmqllfl
3-9 j: njhfczjmmn
3-5 q: scqrdqq
2-16 q: tvgkgqqcpqmpjkqqqqqb
11-13 q: vdrmqfqqqqqqdjqq
3-8 j: jftcskds
10-11 j: ljjwfjtxqjh
7-16 z: zqtcldzxqmzmgzbz
6-14 v: vvvvvvvvvjvvvvv
1-13 q: qdrqgpcqzbpqftws
6-8 d: mdgddbtdddzd
1-6 g: gggjgggggg
1-4 d: djddbhddkdtkvt
11-12 l: lllllllllllll
1-9 g: gggggnvgm
7-17 v: vvvvvvxvvvvvvvvvv
7-11 m: mmmmmmmmmmh
2-4 m: cmfmcpm
4-5 m: mmmmjm
6-9 q: qzcqxbvqfk
1-2 s: ssnssms
2-4 m: xmmz
15-18 h: rtzvhbrpsrbhxqchbz
5-6 w: jwwwwnwt
4-5 m: jmrmwfqmrmtgmm
8-11 p: pkpjpmpppxzpp
1-7 s: sssspssszss
3-6 l: lclllllknlm
1-2 p: pwrwlc
7-9 s: ssssssxhfss
5-9 l: llllllllflllgl
12-19 n: clkznzskfvxngwnnclpx
14-18 n: nnnnnxnnnnnnnnnnngnn
1-8 m: vwbpmmsxmvbwsggqgxd
10-11 q: nqqqqgqfqpf
4-15 b: fctbwzqnwbnvqbqlb";
            
            
            List<(int, int, string, string)> myShit = new List<(int, int, string, string)>();
            var rezult = 0;
            foreach (var VARIABLE in input.Split('\n'))
            {
                var rez = VARIABLE.Split(" ");
                int minval = int.Parse(rez[0].Split("-")[0]);
                int maxval = int.Parse(rez[0].Split("-")[1]);
                string letter = rez[1].Replace(":", string.Empty);
                string password = rez[2];

                var maxRezult = password.Aggregate(0, (total, next) => next.ToString() == letter ? total + 1 : total);

                if (minval <= maxRezult && maxval >= maxRezult)
                    rezult++;
            }

            Console.ReadLine();
        }
        
        private static void Task_2_2()
        {
            var input = $@"8-9 n: nnnnnnnnn
14-15 d: dzjgbdwdkdhdddh
16-17 m: mmmmmmmmmxmmmmwmm
7-17 d: pmgdhpqbqdhshgtjt
1-2 b: mvmgzbmfbrcnr
16-17 c: cccccccccccqcccgcc
1-6 x: ctqxsh
1-5 l: lllvw
9-10 k: kkkkkkklrsnk
7-9 g: xsgzggbglgtm
3-4 b: brwb
4-5 x: xdxlfx
5-6 c: cccccc
4-7 v: vvvvvdpx
2-7 s: qwdngzbtsntgzmxz
6-8 s: ssssssssssss
2-3 t: tjcttt
2-4 z: nbgfl
11-12 z: gnjzwzwzzwcbhv
4-5 v: tvkfvnvvvvcv
1-3 h: hhbhh
15-16 g: gggggggggggggggv
6-9 t: ftjztttfnztv
2-5 v: vxpmqvvzvnglvvv
2-4 r: rsxq
3-4 k: kxkk
2-3 k: kkkk
3-6 t: ktttztt
1-2 v: zvcvv
14-16 b: bbbbbbbbbbbbbrbb
7-10 b: sgmbgmxbxnpjgpthcbr
5-13 r: wmfmgmxxwgbrpllfqnjj
3-4 t: ftcd
2-3 z: szzf
1-6 j: cxjjbj
2-3 t: ttvt
2-6 h: hhkszjhjjxhqhrhn
3-4 s: ssns
4-8 x: xcjmwxxxlrqxxfx
3-10 g: ggvggggkgrggggggxg
2-6 z: lzmhmvftsvcjfhfw
9-14 x: xxxxxxxxhxxxxxxxxx
8-16 d: dddddddddfdddddtd
1-2 g: wrhg
2-7 r: krjrxmrrvhzrprr
11-18 v: vvwvdwslcxvtkzvvkr
9-10 m: mmmxfmmmmmmmmmmz
7-12 g: ggktlgggsqpgw
6-8 t: tttttbtpz
8-18 h: nfhhwkthhxhhcshhwh
10-16 c: smnclksccmnmcmzcc
14-15 f: nmndkphffnqmffj
4-10 f: ffcwqvfffffvfg
6-13 v: vvnvvcvxwxfvvvvvvvv
1-4 k: qklkkkspwkxfk
7-9 w: wwwwwwwwk
9-10 c: ccccccccbpc
11-14 r: qrxrjbbtrxrrrr
2-5 j: wckjjdjjjzvhsqr
10-12 x: xxxxxxxxxcxxx
3-8 l: vnlslkhlwdd
4-12 n: nxnfnqnnzmngnn
4-5 z: zzgpzzc
4-5 z: zgmtbz
2-3 v: vkvv
11-12 q: mqrqmlfqqqqlq
6-14 g: lggzggfxggsggqggxg
3-8 q: sqzqrbgvzp
6-7 l: lllklll
5-7 c: czrccvcclm
11-17 r: rrwrrrrrrdrrrrrrbrrr
2-4 x: xsxx
3-9 l: llllllllwl
3-19 c: ccccccccjccccvczcccc
5-6 h: zhvhhhhghb
1-3 t: ttttvttwt
1-5 p: ppppppp
3-4 g: ssvgr
5-6 t: ndjbtttnmf
14-16 f: fwptdqwwpztqhfnswts
1-2 h: ffvmvbhmh
2-3 f: gdrz
1-2 l: slll
3-5 w: zwwwrwwwwwwww
1-3 w: fszt
8-9 j: jjjjjjjjrj
4-9 k: kkkskkkkkkk
4-9 p: sppzppqpplpp
2-9 s: ssvxrrjhs
11-14 v: cvvvvvvvkvvvvvmv
1-10 q: qqqcmqfjqs
3-7 z: sgzzfzkzz
5-8 w: wwwwhwrztw
3-10 p: phbbmpzhpppspdfr
2-8 c: cscpcccg
2-4 r: rsvr
14-16 h: hhhhhhhhhhhhhhhh
1-13 j: jjjjjjjjhjxjxjjjj
7-8 v: vvvvvvvvv
4-8 r: vbhlmwrrvmkrwn
3-4 c: ccdc
3-5 h: hbjxx
3-4 q: qqdqq
10-14 k: dkkwnrkkhkwzhkkkk
1-3 z: zzzzzzm
3-7 t: tbtxfttvw
6-18 n: qntgnnnztkhwtnjrnm
4-5 g: gggrng
2-7 c: bclzgcgq
1-8 j: jbjjjjjj
2-3 x: jxxfbtxskxc
5-7 g: kgszqgcgxgqtppgb
1-6 l: llllltll
3-4 g: brgm
12-16 x: xsxxxxqpxxvxmxjxxx
6-7 k: kkkkkkk
3-9 f: fftbvjfvfffstzfff
14-15 r: khlwrfrcnrkddrh
2-4 h: hwhqm
4-5 z: zzzzd
7-10 b: bbbbbbpbbt
8-10 h: hhhhhhhdhn
5-6 c: bccclt
7-11 p: pppppppppppp
4-6 r: rwrrrrrr
9-17 m: mmmmmmmmmmmmmmmmmmm
3-9 n: nnnfnnnnjnn
3-4 q: rqqcq
1-2 z: mbzz
1-6 h: hhhhhs
10-11 h: whhhrvtghhh
5-6 g: ggggjz
5-8 g: gggbgggvg
15-16 v: vvvvvvvvvvvrvvtv
5-7 q: qwrzqbllqqqrgkqnlsr
2-4 c: ccccc
7-14 p: spppxpppphblprm
4-9 j: qzxlxdzsdlnlhw
2-4 l: lzphl
16-17 g: ggggggsgggggggxpqggs
3-17 d: ddddddddddddldddcddd
10-12 n: qtkgqxknvjnnsbnrwtp
8-13 d: dddddddcddsdkdd
7-16 v: wkntvjdvvwvfvnqvm
2-5 w: vwhjw
2-3 f: dmgff
2-5 p: nklmmzp
4-5 x: vxxxxd
1-2 m: mmmqm
9-12 r: rrrrrrrrqrrm
6-9 r: ldvhvrjdkqhmr
2-9 f: fmkffptffzdgk
5-12 x: xxxxxxxxxxxbxxxxx
3-4 w: bwwqgwt
10-11 f: fffffffffhfff
10-13 n: nnfnmnhnnnnnmn
12-13 n: nnnnnnnnnnnnnn
8-13 z: rzzfbzzdrzlkn
13-14 p: qgkxppfppfjcnx
3-4 z: bcxdctzg
3-9 z: zznzwzzmffqxj
1-2 n: nnnznr
2-6 s: mtspsskswf
2-15 g: ggggggggggggggqg
3-8 x: tzxqfjrkpdgkxptbxm
15-19 v: dvcvvvvvvvvvlvqvvvv
4-9 r: dszrbrbzrwlfxpcrkn
6-7 f: fffffsmf
5-8 v: vdvvvvrv
10-11 m: mmmmrmmmmmhmmm
9-12 s: stwssszcsssr
8-15 j: jjbjjjjjjjjjjhj
6-8 v: vvvvvhvv
1-7 w: ghxwddwwbfchvtff
6-9 v: vvtxxrbqpvdvvv
3-5 q: fqfqrskl
15-17 k: kkkkzkkkkvbkkksrlkkk
2-18 w: rtfwsrwcbpwtwjzmwwws
5-7 f: pfshgsnff
8-20 h: jkkhhhssfppkjqdfdhtp
2-7 b: bblqbfhbbbb
3-6 j: wjmjjxjj
4-13 d: dfzdkqpddgchbhtgg
4-7 x: xxxxtsn
5-6 m: mmmmmmtm
4-5 p: pkmppck
1-14 j: jpjjwjjkjjmxkjwqj
3-4 s: qxsfvs
8-9 k: kkkwkzxrvkkkk
13-15 r: qzrzrrbrxrcrzjpr
1-4 l: lmvlj
1-4 l: mrll
11-15 w: wqwwwnwwwwtwwfwwjww
8-9 g: fggzsggmggggccm
2-5 f: vggqfcffxh
2-4 c: cwcccr
11-12 c: ccccccccccfc
3-5 g: ggmggg
10-11 l: llllllllrll
5-6 v: wvdjvv
6-7 p: ppppphkp
7-10 c: tcccccnccjcccc
8-10 m: mmmrmmlgmt
3-14 j: ljsjjjjtjjjjjhj
10-16 c: kcjcccccccccnvtccccc
1-9 n: tnjnnnnnnnn
3-7 h: mhdpxhhh
15-16 c: ccccccgcccccccgcc
6-8 t: tvkddtrt
3-4 k: fkhjk
9-11 v: bqmhnjvpvxr
7-9 x: xxxxxxsxpx
16-17 h: hgjzqhvqhsgcplwmhvth
16-17 p: ppppppppppppppkqvp
8-11 l: lllllzlbclslt
4-18 k: kkkkkbkkkkkqkkkkkks
1-8 b: cxbvpxbzbsz
1-12 f: ffffffffffffffff
13-19 d: ddddddddddddkddddddd
9-11 v: mtvvvvvvhvgvv
10-11 t: tttttttttdtttt
5-9 g: gglgggpgdlgtcqg
7-10 m: mzmmmmmmrn
5-6 q: qqqqsq
8-11 f: ffrcfbfnwffzfpxfbvf
7-10 f: ffvfffxbpfffmjfqb
2-3 r: rrrr
6-7 x: bxxxxxgj
3-5 j: jljndr
4-14 q: qqqzqqqqqqpqqdqqqqqq
3-6 n: nnnnntnnn
15-16 g: ggggggggggggghggg
13-16 x: jxxzqxvxfhxxvggxdqx
4-6 f: zfxfkfhmsfgjf
9-12 r: rrrrrrrrgrrnrrrrv
3-7 w: wczsqxwdw
9-12 k: hxgkkklkkkkwkkk
1-4 s: sssns
5-6 v: vvdvlv
12-14 g: gsgggggggggggkgg
5-16 r: rlkqflvvtfcdckfrn
18-19 c: cfncccccccccccccclzc
4-8 n: nbntnnnvnnnnnn
3-6 l: jfpxllfrbll
4-14 k: xphrkstmqmqhkw
2-10 b: rrsrbbqvbr
5-7 k: wkbgkkkqfkkkk
5-6 k: kkkkkkk
7-10 k: mqrsjkksskswqz
11-14 x: kxxxxxcxxxnxpbdx
2-15 h: hhhhhhhhhhhhhhh
5-12 p: pppjpvgppppppppprv
2-11 l: lzlllllllpdlll
5-7 t: xwtzttvctqtpvbltpbtt
2-18 k: ckhhplvxfrdqkbjhbkpp
12-14 k: rkkqvkfngkkqjn
3-7 n: mtxnkbnw
3-11 z: zzzbzzzqzmzzczzzz
3-4 m: mmmq
2-7 s: ssssskcnssgnkzd
3-4 g: rmgrggd
2-3 h: grhrtpcch
2-6 d: dddddddv
3-7 g: jggggggggrfggggg
5-6 v: ljztvvqrcsjdnlwv
2-6 x: vxxtwk
2-8 v: vvvvvvvvjv
3-5 h: dwhwv
2-7 n: ttxgbdbwnnnvnnx
2-4 c: cctfcsb
16-17 c: ccccccccgcxckccxccc
5-6 x: xxxxxx
2-6 p: pwndpfrpppppppppppkp
1-4 h: zhhjlh
2-5 p: prpxwppljppvwjtppkp
2-6 j: bjjjjjjf
16-20 p: pmppppbpppppppppsdpn
1-3 b: bbbh
8-11 k: nkxskkbkfjvcjkdcgrk
7-12 c: cqcdcccgchnd
5-7 m: mmmmmmmmmmmmmmm
4-12 j: kjdjjvrjxsjw
7-16 c: dfzcsdcdgrxvfkjzccmw
1-12 m: mmmmmmmmmmmmmmmmzmm
1-2 s: sssws
1-5 x: xrtxs
3-4 w: wvwv
6-7 s: sssssss
11-12 m: lbwtvjjmmggm
16-17 l: llllllllllllwllht
11-13 t: qtttttgtttttdmt
2-5 r: ldgrf
13-18 r: rrrrrrrrrrrrrrrprr
12-19 l: lnfnhllrjgcllhjlczl
6-7 c: clccccv
9-14 b: shlfbcxhbbmbbzbg
4-6 s: sjssvxdx
11-12 v: vvvvjppqkvqv
5-7 j: jjjjmjjjj
8-11 l: dsldfrdvbll
3-4 p: pkvmcps
2-3 s: ssss
8-11 j: txbxnpwqxjm
4-6 d: drdvdd
4-8 v: xgwkxvfq
1-5 t: zttttttttqmtt
5-8 c: ccjccccqc
9-18 z: zzzzzzzzzzzzzzzmsgzz
1-4 q: qqqkq
10-11 w: wwwwwwwwwwww
5-9 r: prtdrksjbmzmrq
1-3 v: bvvnsmrdgxmnxjjv
6-11 d: drnkdpvdvhfrfgzkn
5-9 h: khhrhhhtvhtznhf
1-3 g: gfpgn
4-5 p: pppfg
8-19 n: nnnnnnnrnnnnnnnnnnzn
6-13 c: cztfcwpjcczsc
3-4 r: rrrg
4-6 t: tfjvtv
4-7 g: nggggggg
2-3 c: cmkc
7-15 r: jrrrrrrrrrrrrrwtrrqr
8-12 h: hjtpfjpbbzwhw
7-8 d: jddddddd
1-9 s: lsssssssmss
18-19 m: mmmmmlmkmmtdwmmmmmh
5-9 t: ttzstqtmt
7-11 x: xxxwxxxxkxxxxgfxxx
2-3 s: dssjzpsxjr
3-4 g: gcgtg
3-4 f: ffxff
9-11 v: tvvvvvfslvvfvv
1-7 n: nmlfmnz
5-6 q: gqzqtqlq
4-5 v: pvvvczdtwthvc
1-3 z: zzrd
6-7 b: sbbmbnbbrp
3-7 l: lkllvqplww
7-9 s: sssssssss
1-8 g: gggkvggsgg
5-6 n: nhnplpl
2-9 g: vgnfzjfvjmmtgd
1-4 d: dcddddddqdh
1-9 z: zzzzzzzzzz
8-10 q: wqhcwqdqqq
7-18 z: tfrfdpwpphzplxfbnw
7-10 f: rffnjdnffmfffrzfqgz
6-7 p: pppppppp
2-13 n: cndfbtxgqzmtnmq
14-19 v: vvvbvvvvvpvvvsvvvvvv
8-11 b: bbblbtwbbbbbb
3-5 v: rfvvv
15-17 n: snmnnnnnwnnnnnnnnnn
4-12 q: sqqqhwnbqqxqbvfrk
4-6 l: lllllvl
17-18 c: cccccccccccccccccc
1-12 t: gttttttxnttzttt
16-17 t: kfmtctsqttztmsxtf
7-14 f: ffffffcjffcfjfff
5-19 b: jtvbbbrbbbjbcsbbvvb
7-8 g: gggggggk
2-4 w: dwvwww
1-3 r: rrrrrrm
7-8 q: qqcqqqqq
6-9 m: tvglftcxmmnshcvscp
3-6 m: cmgmmdmm
6-9 k: kkkdkwzkgk
2-15 w: bwqwwhpwvfpdwdvjwvk
7-8 h: jdhhnhrdghh
3-6 l: llxllpl
4-11 q: ggrjmwhrqdc
7-8 w: cwcwwwwwww
5-6 s: sssssls
6-9 w: rwjwjwwww
1-8 c: ccncccccccccc
2-4 b: xkbbf
6-9 t: ttttttttrt
14-15 h: hbhhhhhhhhhhhhw
14-17 t: ttttgtttdttttttttt
4-7 q: gqmqrqr
9-11 j: tjjjsjwjglpjjjkjjg
18-19 j: jjjjjjjjjjjjjjjjjjf
15-17 p: ppppvhppppppppppp
3-5 d: jlqcqdnprnddpd
6-8 n: nnnnnnnn
5-7 h: cwhhthhhv
3-5 z: wqzmzpbjstzjpfww
2-9 c: fkthkshccccczcph
11-12 c: hcsscmqcdcgp
8-9 t: tttttttkq
3-4 m: tnmcvtljnpdphg
11-19 l: wqjvlvzrgxlvrngwlktj
6-14 s: dxzsssssmzgsmssss
4-7 c: ccckjchc
8-9 s: ssssssrslsm
16-17 b: bxbbbbbbbbbbbbbbz
3-12 p: mpnpplpkppmbp
14-15 v: vvvvvvvvvvvvtvv
5-6 d: kttkndlslhfg
3-5 w: tlwwl
3-4 n: wnhn
13-14 r: zrbmrrrrrrrrmrrr
3-5 f: fzwgrmzpkcfqkftmz
5-6 s: ssssss
5-7 h: wxpzhhzgwhdxqhmhw
8-12 j: djsgjqjjjjjdj
13-15 h: hhhrhhlhhpjhhhr
6-7 v: vwvmvhw
1-9 k: dmwkkkkzk
1-2 g: ggtkbgvgtvggx
10-18 r: rrrrrrrrpkhrrrrrrxrs
5-10 n: nxbslftnwpnn
4-5 d: ddhdd
12-15 l: lllllllllllllhlll
2-3 m: mmmmmmmmmmmmmmm
1-8 s: ssshsspm
3-5 b: nblhbdbbb
2-4 t: qtjtctndq
2-14 v: vcvkvvttxvkvpvhvvd
12-16 g: gqckxjtggwzgtlqrtjkf
3-10 s: ssvssssrsssbss
2-4 n: knln
4-10 f: xfqlfffbflm
1-3 s: mssshjgshpfrssrss
4-5 t: nttbj
2-13 w: lwqwmwhthzrtwkgp
1-3 r: jrnqb
3-13 k: khkkkvkkfkkqkkhfwzf
4-8 g: gggwgggg
3-4 g: wgjgxhngdt
7-9 k: mgshkgnhkpkjsmkvjp
7-9 d: gdjrfqndcdhddmdhdd
17-18 g: gnggggggggggggggng
14-15 g: ggrgggggggggggg
2-7 x: sxpwxddpxnxtxft
5-6 r: grdvrrrrrwrrrrrgvq
4-5 f: ffffff
8-9 f: fffxffzgff
12-15 f: dfffffffpffgffjlfmvf
10-14 l: dlflltmllplljllvlzll
1-2 j: jtnftndqklxzj
1-5 d: ddjwrdddddddhdddddz
13-14 j: lgztjqgjfbjfxff
5-7 k: kkklqkz
15-18 m: hwvmmpmmpqwsmrwmmmsm
5-6 h: hlvhhhqhlh
2-4 j: jjldjjjx
10-11 f: ffffffffffffff
15-16 t: ttttttttttttmtjttt
3-4 v: vvvv
8-9 n: nndhnclnnnnnrwnn
5-6 r: rxrrrrfrr
4-18 p: vwmppgpzltpplvwvpg
9-10 z: fzzzzzzzrzzz
4-6 n: nnbnvnnn
10-11 x: xxgxxxwxxfrwk
3-14 v: tqvvvjvdvvvzkvvvvv
11-13 z: zzmzzzzhrzrzzzzzp
5-6 s: ssgwsvssqs
2-5 z: zbzfzzds
2-5 s: sssss
1-18 r: rrrrlrrrrrgrrrrgrr
2-3 v: vgvvvvv
3-13 c: qdcvfvkjtczgb
3-9 h: hvhhhhhshh
12-13 x: xdxxxxxxxxxxxx
3-17 q: qqqqqqqqqqqqqqqqcq
12-14 q: khnjqkkxlzpqhqj
14-17 t: tttttttttttttsttpt
15-16 d: kwpdfkbhcdhkwsdh
2-15 m: fmdvntdqklcvmhmqjl
5-7 q: qqqqvqnqqq
3-4 j: mnjjj
4-15 f: lfbffxfpffsfbdfhpfs
8-9 s: sssssssgr
12-14 b: bbbbbbbbbrsbbnbb
2-3 x: xbxpvc
10-14 v: vvvvvvvvvvvvvx
6-13 f: kfvfcfffvfhdn
4-16 k: gnzkfdkmrjvwdjgkf
2-5 l: lljll
2-4 r: dprr
1-20 v: vvvvvhvvvvvvvvvvvvvc
1-2 l: mlzljlvllkpzll
4-13 r: kbzrzdrmdvfcl
6-7 v: vvpvvzvv
6-16 h: dxfwghscmjgfqmmf
6-9 h: hhthhfhhdh
6-10 j: bvqrjjjfdtjjjjj
4-7 k: gklkcrvvkk
2-8 k: ndtdhjpb
13-15 f: ffffffffffffffb
6-7 m: mmmmmmzm
2-15 g: xbgxgfgftvgvgmcgnxc
4-8 q: xkrqvqqq
4-9 v: vvvvvvvtbv
8-16 w: wwwxwxwbbwwwtdww
8-11 h: hdhhhhhcght
3-4 f: ffsb
12-13 h: hhhhghhhdmpfhh
6-7 f: ffdmgfh
1-2 c: pcsc
4-6 q: lkzqqmqqq
3-4 b: bbjg
3-6 f: lmbzffl
10-15 p: prxpdpwqpwplpppp
10-12 p: pppppppppppfp
7-8 m: mmmmmmmjmq
5-8 j: jjjfjbjtjj
8-10 t: tttttttmtm
5-11 k: kkkrhkkkkkk
2-3 c: jcccwcbwfrckb
3-10 n: qnnnnnfnnknnnnfnxn
12-13 h: hhhhhhhhhhlhh
9-10 s: smspmjsssss
6-7 d: dddddmdnd
9-10 g: kpnbgstjjgtbhk
9-13 s: ssssssmshsbsxss
1-2 s: lsfsss
8-9 n: nnnnngnnn
9-10 s: sssfssnssssjs
6-8 m: mmxmmmmmm
4-6 x: xtxjxx
8-11 r: qrqkrwbfjln
9-10 h: hfhhhhhhvq
6-10 k: kpkpkjkkkvk
7-10 b: bbbbhbkmmgbvk
8-10 k: kkkkkkkkplvmmk
1-2 r: rrwr
2-5 d: tdddrddgq
7-9 j: jjjjjjjjfj
15-17 m: mmmmmmmmmmmmmmmmj
5-6 v: vvcvvvfwjvvtn
14-18 t: kznfxrrtfcdntttjrt
3-4 c: cjdcc
17-19 q: qqqqqqqqqqqqqqqqfqh
4-5 k: fzvkk
3-7 p: pgppppppppfpp
10-11 k: kkkkkkvkkkz
6-7 t: tttjcttt
2-4 w: kwlcwbgfwwtqpngnb
4-5 q: kqqvlq
16-17 q: qqqqsbqqqqqqqqqbqq
19-20 q: lndjjddqcqkcjztwfxvw
4-6 p: pppmdccpp
13-15 x: xxxxxxxxxxxxhxw
1-9 d: lmdsdfbjpkmh
8-15 v: vthvwvjvcvvqvvhmvs
6-7 r: qxrrrrpr
3-6 n: cxzxnn
9-11 l: lllbhllhllbll
5-9 d: nbsqdctdkp
1-10 l: lllllllllflllllll
1-5 f: cdsfqzwfnjkhdj
2-5 m: clmgsmmdz
1-6 g: cbqgngzvjpxjbwnlprq
6-8 l: bfxrllllllw
6-9 v: qtcxqvmvvdptxvv
3-4 p: fjqx
5-8 t: tpnttxtlt
5-6 p: pppppf
12-13 q: qqqlqqqqqqqqw
5-6 g: hgggvx
1-2 x: qxxx
6-8 n: nkjnnpnnn
6-8 j: jjjjjjjfjjjjjjjj
4-5 s: sbsjm
2-6 m: lmtmlm
3-6 c: bzvhcccncz
3-5 l: lllglnlmpl
2-9 p: hpbwppwdrlpfwbdkmj
7-10 l: tlzwhnlrkrc
4-6 m: xmmmqdmcl
1-6 d: jkdmmd
5-7 c: cjqlhcdcc
4-10 z: xgtznmnznkzvz
13-15 z: zzzzzzzchzzzqzzzz
2-5 q: qhvqqz
1-9 l: nlllllllzlllllllll
4-5 q: qqqzh
5-7 t: ttpttdt
3-11 l: lmnxlthlmlzksggzll
2-5 q: qprnq
16-18 b: bbbbbbbbbbbhbbbtbgn
3-4 l: rlhl
8-9 n: nwdfntdnsnmzkqthl
6-8 h: hhhhhthv
1-2 x: xcxp
7-11 t: nttttctzxmtt
2-4 b: ksvb
17-18 d: dddddddddddddddpqd
3-5 x: lprxzdhxxvz
7-8 z: zgzzzzlzz
2-3 p: rcpxw
11-17 k: qkkkkkkkthkkkkkmkkk
4-6 s: ssrssswxsssmsk
5-8 d: ddddddddddd
5-17 v: vvtvvvtvdvvvvvvvmcw
3-8 r: rhvfrfcr
12-15 z: zzzzzzzzzzzpzzpzz
7-8 p: jppppvpp
13-18 d: dvdnddddddddgddsdd
10-11 q: hqnqvdpqdqqkq
2-4 x: jcxxl
6-7 q: qqfhfqjqr
10-11 w: kwpwwhwnwwwwwww
3-17 d: dddddddkddhdddddd
4-6 s: ssnhswswlsc
14-17 j: jhjjjrzjjmjfpzjjjjj
1-9 z: ztzhzwzzkdzzr
7-14 s: dcspnghrssxsss
5-12 w: ctbvvxzwbwgqw
7-9 k: kwkkqkkkgkm
11-15 l: gllclqplllrlnlpzllc
15-16 p: hpbpppppjpppppppppp
3-5 k: cklnfv
5-7 t: jczctqm
14-17 j: jjjjjhjjjjjjjsjjjj
9-10 g: gsknxggrgblfprf
5-6 m: zjmmqrflmfpmswcvvmtl
8-9 d: dxdddddds
16-20 w: wwwwwwwwwwwwwwwdwwww
5-7 s: ssssnsbs
5-8 z: bzbgzvzz
2-5 b: wbpkbbnkhcndh
11-13 r: rrrrrrrrrrkrsr
12-17 c: ksffzpccccspsqvjc
2-20 v: vvvtvjvjvvvvvvvvstvv
3-4 z: tzszjqzz
3-12 x: scpxgxqrtxxpjxn
13-16 w: wwwwnwjnzwwwwwwwwwwr
9-12 l: zxlrflvclgck
2-8 s: klsnwsdzbss
5-9 s: ssssssssns
1-9 q: fqqqqqqqqqqqqqqq
15-17 n: jknfnsvntjqglbnxn
15-16 h: gbpdwhhhhlthrjhh
5-7 w: cjwgkxdwwxl
1-5 j: jmnczjrlqchdwpthbjst
6-8 v: vvvfxkvvvv
5-8 g: ggbgqggmhg
3-15 v: vxvvfzvvwcxvjvvqvvq
6-14 h: drppknzrchcjhh
2-3 n: dgntnq
9-14 s: ssssssssxmsssxssssss
2-4 j: wjrdcjz
5-12 n: dntnnvbfjnznn
3-4 z: zzmnzbsrt
6-9 n: kngngnnbcnhp
6-13 k: tmsskkjkkvtksnm
2-4 w: rwhf
6-7 p: ppppppwdpvp
2-8 r: prqvprbrvrsjxm
1-8 f: gffffffff
6-8 b: lbmtblbptbxfdqb
4-10 r: rrsrrrnrrbmrngrk
10-17 b: bbbbbbbbbmbbbbjbhbb
2-13 v: tmvqcvvwvvqvzvdx
13-19 d: hrtlzplwdkshdbsjmsd
6-13 w: wwwwwwwwwwwwdw
14-16 q: hlkhpvdqrkhkqlhhlg
7-8 m: mmmmmmmx
11-12 p: pppfnpqppppp
4-5 k: kkclzkfk
8-9 k: krkkdkkkk
15-16 w: wwxwwwcwwwwwwwjw
12-16 w: wwwtmwnwqdwvjpwzwwz
5-9 d: wdddrdddrdkdkddd
5-6 p: qppbpvp
1-7 t: fgznlbtgwtnrlhgf
4-10 j: jjjjjjjjjljjj
3-6 z: spgznzcz
11-12 h: xhhhkfhhhhmh
3-12 g: ckgvgbrgcqrggggt
1-6 k: kkkkkjk
2-3 j: qzbf
3-4 r: rrlprrrrrrrrdrrrrr
13-19 l: llllllpllllllllllll
6-10 x: xxxxxjxxxxnx
2-12 f: jffffbffqftf
5-8 b: wbgbgbsb
4-8 t: jflltrxfgttqvrgt
2-5 z: fzzzszcwzz
3-6 w: whwwbnw
12-15 n: nndnnsnnnttnnnnnnn
4-9 c: mcsstwccc
3-4 q: dxwq
6-11 v: swmrlccvxzdrffvvwj
10-11 x: xxmxxxxxxmx
1-2 k: fkqk
15-16 d: nlnzddfrjqvdjwddmw
2-6 k: ldkdmnmcp
1-11 p: fptzpgpzfhp
12-14 b: bbbbbbbbbbtbbx
6-12 w: wwwpbwwmxwxz
1-4 r: mrrrrrr
13-18 w: wwrwgwrlwwwwwwwwwlw
16-19 z: szzzjzzmzzzzzzzzzzsc
2-7 v: qvvcsvd
7-10 s: mtskmnvnlcgsb
6-7 q: mkdqqqq
3-5 x: xwxmx
7-9 q: qsqjfqcqwnq
1-4 r: crcb
14-18 k: lfwklgqjzgxfpkpkfqr
9-14 j: jjjjjrjzjjjjjfj
5-6 x: xxxxxxh
1-17 z: gvczzzzqdqzzzzzmwkzd
11-14 k: dkkklkkpkkkktkkkkkk
9-12 j: jjjjjjjjqjjv
2-6 d: dthddmddd
4-5 v: qvfjfvvdlszqxvbl
4-5 n: nnndn
7-8 c: wqnmpcwf
1-10 c: cvgmnkcssrhqccmddgh
8-9 m: lmmtmxmsm
3-6 v: qvvnqvvrfhv
6-7 x: vxxxxmkjxxxxxxxxxxx
5-14 x: qxjgbxxxxprxxn
13-14 p: dphsqvhrfsbpqpp
3-5 r: trvrrxrrr
2-5 f: fffff
2-6 w: whwdwnwt
2-3 x: wxcsxx
10-14 p: pswtzbkslpqppph
3-5 l: zllllx
9-11 g: ggggggggggxgg
4-6 h: fvhhfhhfjqffhhhwx
7-8 t: wttttttf
11-14 q: qqqqvqqxzcqpqhqkpqtf
5-9 b: bsrbbbxkm
13-15 t: tttttkwtttttgttwt
4-7 c: czccvxtc
9-10 n: nwnnnnnnnn
3-5 f: ffdtf
13-14 h: hhzhhhhhhhzhphh
9-11 g: kgsfsnhsggglgsp
5-6 s: hbxpnsssvx
10-11 t: ltsrtmvmkgm
12-18 k: xlwkkkkktkkkbkkrjxkk
5-7 l: lnllwlw
16-17 k: kkkkkkklkpkkkkkknkk
11-12 t: ttttttttttttt
11-13 v: vvvvvvvgvvvvvvv
10-14 d: ddvddjdddkdddd
3-4 r: nrdrhnr
1-4 q: pqqxcsws
5-6 p: ppppjpp
14-15 b: bmbflqmbzhkbqvb
9-11 t: ttntttttnpt
15-16 l: llsllldflhblwlllf
5-10 w: swwwwnwncwtfrpnw
6-7 j: jjjjjthb
2-4 d: ddhdzfdddlp
2-9 q: jqqqqbqqqzq
19-20 b: bbbgbdbkbbhbsdpbbtbh
7-9 v: hvvvxvvvv
6-7 l: gsbslll
2-6 p: pzpppwpppppppppp
10-11 g: kmkngxnnrfh
1-11 v: rvdvvvvvvvv
2-4 n: nhndnnnnqn
12-13 q: qqqqqqqqqqqqm
7-9 s: ssssxsnsssss
2-15 t: ftntkfmqxzxggcfwb
1-7 v: vvwvvvqdvv
6-14 s: sbsssdssssssfqsss
3-8 w: vwwqwwww
6-10 z: zzzzzzczkzzz
5-8 b: bbvdmxqbbbbbbbbdv
4-8 s: stvsssszcswszs
12-13 x: xxxxxxxxxxxxxx
5-15 d: ngzjdxddjddxvbwzbd
1-10 s: ssssssssss
10-14 r: rnhrrrrrrrznrrr
1-7 z: nvzzzcvzzmzhnprzkz
2-9 w: zfmxnmltsbxpfsh
13-14 l: lllllblllllldgl
3-9 b: dbbrkmmfsmhblqb
1-6 t: tjmrctqggzdgtz
1-14 m: bmmmmmmmmmmmmmmmmmm
3-4 b: mwbndzbjp
9-11 n: nnnnnnccmnb
5-11 b: kpcbqbbbcmbkb
3-6 j: wpjjspjw
6-12 p: pppppppppppdppp
1-4 c: rccc
3-9 l: llllxllbllll
6-14 w: tlpcwxwwwzbtwd
3-4 q: qqqg
3-5 x: htxcvqkwx
15-17 r: rrrrrrrrrwxrrrrrr
8-10 k: kkkkkrkwkkw
3-4 s: jjwhksqrbxs
3-4 g: gvggg
11-13 t: tjgttvtdtbttttttqttr
5-6 j: jjjjmjjj
9-13 f: fffffffflffff
13-14 z: ccbzvzwmzpzzmz
6-7 b: bbjtbbbbbb
3-5 k: pkknmv
3-4 w: wmchw
4-7 b: bbbgbbbbb
10-13 q: qrqqqvxbplqqxqqqmqq
1-8 b: rbbbbbbjbbbcqbb
7-17 q: xqqqqqqqqqqqqqqtq
4-6 k: kqkkbbg
6-14 l: lglhbvslmhqjnw
4-6 w: pwwxxn
12-16 q: tvtqvcchgtmqqznb
8-14 q: hkthhbpjvkpxgq
11-13 m: smmffkhhkrmwnbwrs
8-11 d: dddddddddddd
4-6 m: lmdmmkwmmmfbs
12-20 w: wwwwwwwwwwwbwwwwwwsb
5-7 m: mrnhmplhwczr
7-11 p: pppppdbpppvpc
4-10 p: zpwsppfppj
3-12 d: dddddpfddrdln
8-9 g: chfcgzfgg
5-6 g: gggghg
7-8 q: hqqqxqqqqqqqqqg
4-10 c: cdtpvcccvd
7-8 s: sqwtsxsssss
5-11 v: pcvvrvxvvnpjn
4-6 z: hzmnzg
4-6 b: bslbbbxbbwml
16-18 z: zzzzzzzzzzzzzzzzzg
1-3 h: hhkh
2-4 r: wrtrb
5-6 d: ddddpd
4-7 k: kkkkkkkkkxk
8-13 k: pkkkkkkkkkgkkd
8-13 p: lpxppxpbpgppzppmppp
3-9 m: mmmmmmmmmmmmmm
6-7 h: cpmmhcttgx
11-15 b: bbbbbbqbpkfbbzh
4-7 j: jjqvjjj
6-8 c: gwrfrslcsqmcttzcl
11-13 r: mrrrrrpgrrnrrrr
3-8 q: tqqqqqqz
2-4 f: mtsxj
1-17 g: cgggggsgggdgcgrxg
1-9 m: mhgqjqxjnpmmmgnmfpm
2-4 g: rggbc
2-4 w: wgfw
7-9 d: qdmddddddmxdd
12-13 t: ttmjznwtwtttz
11-12 b: kjbkbgdbwbmcb
4-5 h: mhvhh
4-6 t: ttvttttt
9-12 r: zwlljhfrrfrr
3-4 j: jjjj
2-7 v: vvvvvvmvv
9-19 n: nnnnnnnnmnnnnnnnnnqn
1-3 q: qfflx
8-10 k: kkkkkkknkk
4-9 k: kvrspqfkkqj
14-15 b: bbbbbbbbbbbbbbbb
3-8 d: qrdsfdwd
5-8 j: jjxmrtjjjjkpnnjt
14-15 f: fnlnbzqffrrnffgf
1-4 f: fnff
4-5 x: xxxtx
5-6 q: qtqqlmqqq
14-15 f: fflffdfffffffkjfff
1-5 k: kkqkvkk
5-9 b: nbjtwbbgw
13-19 v: ssjjggrvrnbpvjlggsf
8-10 x: xxxxmxxxxx
4-5 d: vdwhtcsc
1-7 l: zlllllglll
2-5 d: drjpdwrlnpfqqrnlh
12-13 p: fthsszdpjcqxd
14-17 z: zzczzzzzzzzzzzzznzz
6-11 m: hhcsqmvmfgmkmbm
7-8 m: hmmmmmcmm
6-7 l: lllllgl
5-10 t: tttktdzttlcttv
6-12 m: nmmmpmmmxtmmjmxm
4-5 q: qnqnnqqqqqqq
1-4 c: zkpcc
5-6 n: nbphjnfn
6-7 f: ffffxqrf
1-6 g: lgggggggg
5-11 p: mbfpppplhdp
5-8 z: jzvzzkzm
5-7 l: llllllll
5-14 x: gvjvwmhxtzpsfxb
4-13 x: tvlfjxmpfrmqmkhrdlbl
8-11 b: nbbbbrcbbbb
8-10 w: ccccwwgwwwwl
2-13 p: wwwxrsfztddwplfpqx
17-18 c: ccccccccvccccccccj
11-13 d: dphdtwhqwdhmx
15-17 c: ccccccccwcccccccdc
3-4 d: ggjv
3-4 b: bbqbbqbx
2-3 g: qggg
10-18 w: wpbbfmdzhsnbcdxqrh
13-20 v: vpvvvvvvrvvvvsvvvvxv
16-17 w: vwwqhwwwfhwgdkhfw
16-19 b: bbbbbbbbbzpbbkbkbbjb
11-16 x: hczxsbkhxfbtxvzx
10-17 b: bbbbbbbbbsbbbbbbvbb
2-3 p: pppxsznnn
2-7 g: ggggsgggl
15-17 t: tttttttthttttttttttt
7-17 f: fffsfftfffffffffffqf
3-7 k: gpfmqbkqmkkkrpkpk
4-7 j: xpbgxjw
14-15 f: ffffftknfklfdff
1-4 k: pkkslkkkkk
4-7 w: czbwgqtpwztxwwbwmqf
1-5 n: tnnnnn
1-5 q: qdqtq
10-15 c: fccqccrkcccczcmcc
9-14 h: hhbbhhhhdhhhhhdhhh
2-6 f: fsbfdcvffhffm
12-15 h: jhhhhhhhhhhhhhs
9-11 p: ppppppppppbp
15-16 d: txdbddddjdsdbrvddddp
5-6 w: wqkwrv
2-4 z: zzjnsjspkgdkmvvlh
13-14 z: zzbzzzzzzzkzzzz
9-10 v: vvvvvvvvvcv
13-15 g: gggggggggpqgtgv
1-17 j: bjjjjjjgjjjjjjjjjjj
5-7 x: dpsxxxx
17-20 d: ddvxddtdhdrddjddnddd
5-6 f: ffxffp
12-14 w: wwwwwgwwwwwwwq
8-13 t: rnthvkbtnxvltsjn
4-5 q: qqqdq
4-12 s: ssssssssssszs
3-4 s: sssw
2-5 x: kzxwxqljv
1-3 x: rhxxdxxxdg
11-12 t: tthtstttgztrt
1-4 n: qzdnkpkrzgxdztdcfn
12-15 g: fgdzsqwkfdhrbsjz
1-3 g: kggg
6-9 c: hcwcccpcccwcck
8-9 r: rqrlrggwrrjfzgkmrq
4-5 r: ghzlrrrgs
9-11 g: ggggggdggggr
12-14 f: fffffffffffcffffff
3-7 z: mgzmpjz
1-6 h: hhzzbm
18-19 g: ggfhhvggffkqfgjnggg
1-8 p: ppppppphwppwr
13-15 l: qmjnjfnnlmbqgllwhk
5-13 z: zgpwzhwnmptrzrq
3-4 v: xnvnqjjrvvlgv
14-15 p: pppgpphppppppwpnrpr
9-13 h: hxfhhshbqhnhhp
5-6 w: wkvqbtbtfmsbwkwwhdwb
1-3 x: shxxx
1-2 v: vhvt
5-8 c: zdrlnhcctcpccsntl
12-19 x: xxxxppxxxmfglxfxmxg
3-4 v: vfqwq
8-9 f: fffffffxx
11-14 l: lslvlnbsjlbllmqllfl
3-9 j: njhfczjmmn
3-5 q: scqrdqq
2-16 q: tvgkgqqcpqmpjkqqqqqb
11-13 q: vdrmqfqqqqqqdjqq
3-8 j: jftcskds
10-11 j: ljjwfjtxqjh
7-16 z: zqtcldzxqmzmgzbz
6-14 v: vvvvvvvvvjvvvvv
1-13 q: qdrqgpcqzbpqftws
6-8 d: mdgddbtdddzd
1-6 g: gggjgggggg
1-4 d: djddbhddkdtkvt
11-12 l: lllllllllllll
1-9 g: gggggnvgm
7-17 v: vvvvvvxvvvvvvvvvv
7-11 m: mmmmmmmmmmh
2-4 m: cmfmcpm
4-5 m: mmmmjm
6-9 q: qzcqxbvqfk
1-2 s: ssnssms
2-4 m: xmmz
15-18 h: rtzvhbrpsrbhxqchbz
5-6 w: jwwwwnwt
4-5 m: jmrmwfqmrmtgmm
8-11 p: pkpjpmpppxzpp
1-7 s: sssspssszss
3-6 l: lclllllknlm
1-2 p: pwrwlc
7-9 s: ssssssxhfss
5-9 l: llllllllflllgl
12-19 n: clkznzskfvxngwnnclpx
14-18 n: nnnnnxnnnnnnnnnnngnn
1-8 m: vwbpmmsxmvbwsggqgxd
10-11 q: nqqqqgqfqpf
4-15 b: fctbwzqnwbnvqbqlb";
            
            
            List<(int, int, string, string)> myShit = new List<(int, int, string, string)>();
            var rezult = 0;
            foreach (var VARIABLE in input.Split('\n'))
            {
                var rez = VARIABLE.Split(" ");
                int minval = int.Parse(rez[0].Split("-")[0]);
                int maxval = int.Parse(rez[0].Split("-")[1]);
                string letter = rez[1].Replace(":", string.Empty);
                string password = rez[2];

                if (password.Length >= maxval &&
                    (password[maxval - 1].ToString() == letter ^ password[minval - 1].ToString() == letter))
                {
                    rezult++;
                }
            }

            Console.ReadLine();
        }
        
        private static void Task_3_1()
        {
            #region Real Data

            var inputReal = $@"....#...............##...#...#.
#...#..#.....##.##.#.##....#...
...#.....#...#.................
#..#..#.......#...#.#..........
...##..#.#..........##...#.....
........###.#.##..#............
...###......##.#..#.#...#.#....
......##..#.#....#...#.........
.................#......#......
..............##....#..........
#.....................#...#.#.#
.##..#............##...##.##..#
.....#.####...#..##......#.#..#
#.......#.#..#......##.#.#....#
.....##...###.#..........##....
#...........#.##....##.....#..#
..###..##.##.....#....#........
...#.#.#............#.#..#....#
#......#....#...##.#.#.#.#..#..
.......#.#...#..#..#..##......#
.....#..#.............#..#...#.
##..#.##.....#........#........
....##....#..#...........#...#.
.......#........##.......##....
..##...#.......#........##.#...
..........#..#.....##........#.
..#..##..#............#........
.#.#...#...#.......#......#....
....#....#.....#.#.........###.
.............#...#....#..#.#...
##.#...#..#......#.#.##.....#..
#...##.#..........#..#.#...#...
#####.......#.#.....#..#.......
#...#...#........#....#...#....
......##.#..#..#............#..
....#....#.......#...###.......
.#......##...#.##....#...#.....
..#....#...##.....#.#...##.#...
#.......#........#.####........
#.##..#..#.........#.#........#
.#...#.#.#.#......#....#.#..#..
#...####...##.##.#....#......##
..#...#......##........#.....#.
...#.#....##...................
...##................#.........
...##.....##........#....#..#..
.........#..#.....#............
.#..#.......................#..
.#.........#..##........#.#.#.#
......#.....##..#.##...#..#.##.
..#..............##.......#....
...............##....#...##..#.
###...#..###.........#...#.....
...#..#...#....#.....##........
....#..##...#........#.........
..#......#.......#.....#..#....
.#...........##.....###....#...
.#..#.....##.........##.....#..
....##.#.....#................#
..#..#......#.#..#....#..##....
#.....#...##............#......
.#.............#....#.......#..
#.........#..#...##.#...#.#.##.
...#......#..####....#.#.....#.
......#........#..........##.##
......##.#..##.##.....#........
##.....#..##.##..#.......##....
.##.........#...........#...#..
.....#...###..#...#...........#
..........#.#......#.###.....#.
...#.............#.##......##..
#.##.........#..###...........#
....#..##....#..#..#........###
...#........##.......##..#..#..
...#......#..#.#...............
#......###....#.#..#.#..#....#.
#.#.####.#.........#..#.#.#....
.....#....#...............#...#
.#........#......#.#...#.......
................#...#.....##...
.............#...####..........
.................##....##.###..
#................#......#......
.###.#........#..##.....#..###.
..#.#..#...#..#.#...#.#.....#.#
.....#............#..##..#..#.#
#........##.#...#.....#........
#.#.#..###......###............
...#..#...........##...#.....#.
......#........#...#.#....#....
....#..........#.#..#.#....##..
...#.....##..#......#.#.##...#.
.........#..#................#.
..#....#.##.....#.......#......
...#.....#.......##.##.....#...
#...#..............#..###..#...
#.#......#.#....#........##..#.
...#...##...##..#.........#....
..#...#......##.#.#.#....##....
#.......#.......#..#..#........
.........#..#.....#....#.....##
.#......#.......#.#..#..#...#.#
..#....#.#..#..................
#.....####..........#.#.....#.#
.#..#.#.#....#.#.....#.#.......
....##......#..#.....#.#.#...#.
...##...#......##.#....##.#....
..#..##....#...#...........#...
.......#........#...##.#.......
#.#..#....##.#....##...........
.......#............#..##..##..
#.#.#.....#....##.#.#.#.....#..
##...#...#.......#..#...#.....#
##..##.##..........#........##.
..............#.....#..#..##...
.......#...#.........#....#.#..
...#..#..#....#.#....##........
..#.......#....#....##.........
#...#.....#..#.#...##....#.....
.....##..#..##..#..............
.....##............#....#.#....
..#.....#....##.#.....#..#.....
#...#..#..#......#.#.#..##.....
.............................##
#...#.#................#....#.#
.#.#.#....##......###..##......
#.....#..#.##.#.#.##...###.....
.........#............##..#....
.#..#...#....#.....#.#........#
...............#......#..#.....
...................###........#
.###..##..##.......#.#.........
#.........#......#....#.#...#..
.#.#....#.......#.#..##...##...
.#.....#....##.......#.#.....#.
.........#...#....#.#..........
....###..#..##.#...##....#..#..
...#.#..##.#.........###.#..#..
#...#...........#....#.........
....##...........#.#.#......###
#....#...........##..#.........
###....#.....#.......#....###..
.#.......#....#.#.#.#......#.#.
........#...............#.#.#..
....#.........#.....#...##.##.#
...#............#.............#
..........#..#.................
........#.....##............#.#
..#...##........#...#.....#.#..
....#........#.#.#..........#..
#.#...#...........#............
....#.#...##...........#.....#.
...........#.#..#.....#........
.....#..#..#..#.....#.#.....#.#
#.....#.......#.......#...#....
#.........#....#.#........#..#.
...#..#.........#.....#..#.....
...#..#.............#..........
.#.......#..........#.....#...#
.....#.#......#.......#....#...
...#.....#..#..##....##....#...
.#.#.#..#...#.....#....#.......
..##.#..........#.....#.#......
..#..#.............#...##..##..
.#.............#..#....##...#..
..#...#.....#.................#
..##.......#.....#...#....#....
.#..#.##.........#...#.#...#...
...##.......##..#.....##.##...#
........####.#.........#.......
..#.#...##.#..#..#.......##.#..
.#..#............###..#..#.....
#.....#.#...#.#.......#........
..........#......#.#...#...#...
..#......#..#..#.#...#.........
..###........#.#....#.#...##...
.#.....#..#.#......#........#..
.#...#..#...#....#.......#..#..
..#....#..#.....#.#........#...
#..#.#.........#..........#..#.
.#.....##....#.........#.#.#.#.
#.#...#.....#.#.#....#.#..#....
.........#...................#.
..#.....#..##...#..........#.#.
..............#....#.........#.
.#....#.....#..............##..
#...#...#.#........##.........#
....###....#.#....#.#.........#
.....#........#.....##.........
.#...##..##..#.........##......
............#.....#........#...
..#....#.......#......#..#.#.#.
#.......#.#...........#..##.#..
......#.##......#....#.......#.
.....#........#...###.....#....
###..........#........#.#.#....
.....#...#.#...#...#...##.....#
.##...#.#........#.#....#......
......#.........#.....#.#......
.....#.##.....###.#...#...##..#
.#.#.......##....#..#..#.##....
.####...###.#.#.#.#............
......#..##...#..........#.##.#
......#............#...........
.....#.#..#.......##...##......
......#........#..#....#.#.#.#.
#..#..#.....#..#.....#.......#.
.#...#.....#..............#....
.#....#..#.##.#............####
..........#....#.##...#.#......
...#.#.#.#.#.......#.........#.
##........#..##..#.........#...
..#......#...#..#.#.....#......
..#.#......#...#...#.#.........
........................##.....
...#.##.#........#...#.......#.
..#.#......#....##........#.#..
#......#.##........#..#......#.
.....#..#..#.............#.....
......#......#........#....#...
...#....###.....#..#.#....#....
#.......................#....#.
..#...#...................#....
....#..#.....##.#..#...#.....#.
...#.........#...#.......#.....
..#....#.....#...#...#.#####...
.....####......#...........#...
......#.#..........#...#.#.#..#
###..#.#....#..#...............
...#...###..#..#.#.#...........
.....#...#.##.#.#.###..##......
.........#...........#....##.#.
....#..#......#................
...........#..#..#...#.#.......
..#.....#......##.###..........
.........#...................#.
..........#...#.#....##........
..#...##....#....#.......#...##
#......#.....#...#...#...#.....
....##...#.#.......#.#...##....
...#.....#....#.....#....#.....
#....##.....##..##..........##.
.....#.....#.#.#...............
.#.##....#.....#.#..#....#..##.
.....#.#.....##....#...........
.........#..#.......##..##.....
..#....##.....###...#....#.#...
............#......#.#...#..#..
#..##......#.#.##....#.#.......
.#.#.....#...#.#.#....#.....#..
#....#..#.#....#...#...........
......#.#.....#...#.#.#......#.
###..#....#.###.............#..
..............#####........###.
..#..#.#.#.#......#......#.....
###.........#.#..........#..#.#
.#.........#...#......####.....
..#.......####..#....#...#..#..
#.#..#.#...............#.#.#.#.
###....#.....##.#....#......##.
..#..#........#....###.#.#.....
...#.#..........#.....#...#....
....#......##.#............#..#
...##...#.....#..##....#..#.#.#
.......#.....#..#....#....##.#.
.#..#....#..#......##....##...#
..#......#...#.#..###..#.##....
#...#.....#......##...#.......#
.....#.#.....#...##............
.#..##.##..#..##.#........#....
....#.#......##...#.#.#.#..##..
.#..............##........#....
.##....#..#..#....#...#......#.
............###....##.......##.
..............####.....#.......
........##..##.#...#.......#...
....#..#.....##.......#####...#
.##..##..#.....#...#..#..#....#
##..#.#.#...........#..........
#..#......#...#....#...........
...#..##.#..........#..#.......
........#.#.....#......##......
.....#....#............#.......
.#.#..#....##......#.......###.
.#..#.#........#......#...##..#
...#....#......#..#........#.##
.........#..#...#..#.#.##......
....###.#...........#...#......
.##............#.......#..##...
##...#.#...............#.#...##
..#..#.....#.#..#..#...........
..#..#.##..#......#.##..#.#....
..#...#......#.#...#....##.#...
...###....####......#....#...#.
.......##........#.....##....#.
.........##..........#...#.....
.....#............#.##.#....#.#
..........#...#....##..........
....................#......#...
#......#..#...#.............##.
...........#...................
..#...#.........#.##.#..##.#...
#.#....#.#.....#............#..
.#..#.....#.....####......#.#..
#....#.......##..#...........#.
............#...#.....#..#.#...
#...........#...#####....#...#.
..........#...###..##.........#
#.....###............#..#..#.#.
...##.....#....#......#.....#..
#....#.......#..#......###...#.
...##.##......##..##..........#
.......#.#..#.#..#.#.#.#..#..#.
..#..###...#....#.....#......#.
...#.........#..#.##.#.....###.
..#.........#.##.#..#..#..###..
..####..#.........#.........#.#
..#.#...#.......#....##........
.#......#.#....................
..........#.......#.#..#..#....
..#........#....#.#..#.........
..#.....#.............#....#...
##...#.........#.....#...#.....";

            #endregion
            
            var strings = inputReal.Split("\r\n");

            var treesCounter = 0;

            for (int i = 0, right = 0; i < strings.Length; i++, right += 3)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter++;
            }

            Console.ReadLine();
        }
           
        private static void Task_3_2()
        {
            #region Real Data

            var inputReal = $@"....#...............##...#...#.
#...#..#.....##.##.#.##....#...
...#.....#...#.................
#..#..#.......#...#.#..........
...##..#.#..........##...#.....
........###.#.##..#............
...###......##.#..#.#...#.#....
......##..#.#....#...#.........
.................#......#......
..............##....#..........
#.....................#...#.#.#
.##..#............##...##.##..#
.....#.####...#..##......#.#..#
#.......#.#..#......##.#.#....#
.....##...###.#..........##....
#...........#.##....##.....#..#
..###..##.##.....#....#........
...#.#.#............#.#..#....#
#......#....#...##.#.#.#.#..#..
.......#.#...#..#..#..##......#
.....#..#.............#..#...#.
##..#.##.....#........#........
....##....#..#...........#...#.
.......#........##.......##....
..##...#.......#........##.#...
..........#..#.....##........#.
..#..##..#............#........
.#.#...#...#.......#......#....
....#....#.....#.#.........###.
.............#...#....#..#.#...
##.#...#..#......#.#.##.....#..
#...##.#..........#..#.#...#...
#####.......#.#.....#..#.......
#...#...#........#....#...#....
......##.#..#..#............#..
....#....#.......#...###.......
.#......##...#.##....#...#.....
..#....#...##.....#.#...##.#...
#.......#........#.####........
#.##..#..#.........#.#........#
.#...#.#.#.#......#....#.#..#..
#...####...##.##.#....#......##
..#...#......##........#.....#.
...#.#....##...................
...##................#.........
...##.....##........#....#..#..
.........#..#.....#............
.#..#.......................#..
.#.........#..##........#.#.#.#
......#.....##..#.##...#..#.##.
..#..............##.......#....
...............##....#...##..#.
###...#..###.........#...#.....
...#..#...#....#.....##........
....#..##...#........#.........
..#......#.......#.....#..#....
.#...........##.....###....#...
.#..#.....##.........##.....#..
....##.#.....#................#
..#..#......#.#..#....#..##....
#.....#...##............#......
.#.............#....#.......#..
#.........#..#...##.#...#.#.##.
...#......#..####....#.#.....#.
......#........#..........##.##
......##.#..##.##.....#........
##.....#..##.##..#.......##....
.##.........#...........#...#..
.....#...###..#...#...........#
..........#.#......#.###.....#.
...#.............#.##......##..
#.##.........#..###...........#
....#..##....#..#..#........###
...#........##.......##..#..#..
...#......#..#.#...............
#......###....#.#..#.#..#....#.
#.#.####.#.........#..#.#.#....
.....#....#...............#...#
.#........#......#.#...#.......
................#...#.....##...
.............#...####..........
.................##....##.###..
#................#......#......
.###.#........#..##.....#..###.
..#.#..#...#..#.#...#.#.....#.#
.....#............#..##..#..#.#
#........##.#...#.....#........
#.#.#..###......###............
...#..#...........##...#.....#.
......#........#...#.#....#....
....#..........#.#..#.#....##..
...#.....##..#......#.#.##...#.
.........#..#................#.
..#....#.##.....#.......#......
...#.....#.......##.##.....#...
#...#..............#..###..#...
#.#......#.#....#........##..#.
...#...##...##..#.........#....
..#...#......##.#.#.#....##....
#.......#.......#..#..#........
.........#..#.....#....#.....##
.#......#.......#.#..#..#...#.#
..#....#.#..#..................
#.....####..........#.#.....#.#
.#..#.#.#....#.#.....#.#.......
....##......#..#.....#.#.#...#.
...##...#......##.#....##.#....
..#..##....#...#...........#...
.......#........#...##.#.......
#.#..#....##.#....##...........
.......#............#..##..##..
#.#.#.....#....##.#.#.#.....#..
##...#...#.......#..#...#.....#
##..##.##..........#........##.
..............#.....#..#..##...
.......#...#.........#....#.#..
...#..#..#....#.#....##........
..#.......#....#....##.........
#...#.....#..#.#...##....#.....
.....##..#..##..#..............
.....##............#....#.#....
..#.....#....##.#.....#..#.....
#...#..#..#......#.#.#..##.....
.............................##
#...#.#................#....#.#
.#.#.#....##......###..##......
#.....#..#.##.#.#.##...###.....
.........#............##..#....
.#..#...#....#.....#.#........#
...............#......#..#.....
...................###........#
.###..##..##.......#.#.........
#.........#......#....#.#...#..
.#.#....#.......#.#..##...##...
.#.....#....##.......#.#.....#.
.........#...#....#.#..........
....###..#..##.#...##....#..#..
...#.#..##.#.........###.#..#..
#...#...........#....#.........
....##...........#.#.#......###
#....#...........##..#.........
###....#.....#.......#....###..
.#.......#....#.#.#.#......#.#.
........#...............#.#.#..
....#.........#.....#...##.##.#
...#............#.............#
..........#..#.................
........#.....##............#.#
..#...##........#...#.....#.#..
....#........#.#.#..........#..
#.#...#...........#............
....#.#...##...........#.....#.
...........#.#..#.....#........
.....#..#..#..#.....#.#.....#.#
#.....#.......#.......#...#....
#.........#....#.#........#..#.
...#..#.........#.....#..#.....
...#..#.............#..........
.#.......#..........#.....#...#
.....#.#......#.......#....#...
...#.....#..#..##....##....#...
.#.#.#..#...#.....#....#.......
..##.#..........#.....#.#......
..#..#.............#...##..##..
.#.............#..#....##...#..
..#...#.....#.................#
..##.......#.....#...#....#....
.#..#.##.........#...#.#...#...
...##.......##..#.....##.##...#
........####.#.........#.......
..#.#...##.#..#..#.......##.#..
.#..#............###..#..#.....
#.....#.#...#.#.......#........
..........#......#.#...#...#...
..#......#..#..#.#...#.........
..###........#.#....#.#...##...
.#.....#..#.#......#........#..
.#...#..#...#....#.......#..#..
..#....#..#.....#.#........#...
#..#.#.........#..........#..#.
.#.....##....#.........#.#.#.#.
#.#...#.....#.#.#....#.#..#....
.........#...................#.
..#.....#..##...#..........#.#.
..............#....#.........#.
.#....#.....#..............##..
#...#...#.#........##.........#
....###....#.#....#.#.........#
.....#........#.....##.........
.#...##..##..#.........##......
............#.....#........#...
..#....#.......#......#..#.#.#.
#.......#.#...........#..##.#..
......#.##......#....#.......#.
.....#........#...###.....#....
###..........#........#.#.#....
.....#...#.#...#...#...##.....#
.##...#.#........#.#....#......
......#.........#.....#.#......
.....#.##.....###.#...#...##..#
.#.#.......##....#..#..#.##....
.####...###.#.#.#.#............
......#..##...#..........#.##.#
......#............#...........
.....#.#..#.......##...##......
......#........#..#....#.#.#.#.
#..#..#.....#..#.....#.......#.
.#...#.....#..............#....
.#....#..#.##.#............####
..........#....#.##...#.#......
...#.#.#.#.#.......#.........#.
##........#..##..#.........#...
..#......#...#..#.#.....#......
..#.#......#...#...#.#.........
........................##.....
...#.##.#........#...#.......#.
..#.#......#....##........#.#..
#......#.##........#..#......#.
.....#..#..#.............#.....
......#......#........#....#...
...#....###.....#..#.#....#....
#.......................#....#.
..#...#...................#....
....#..#.....##.#..#...#.....#.
...#.........#...#.......#.....
..#....#.....#...#...#.#####...
.....####......#...........#...
......#.#..........#...#.#.#..#
###..#.#....#..#...............
...#...###..#..#.#.#...........
.....#...#.##.#.#.###..##......
.........#...........#....##.#.
....#..#......#................
...........#..#..#...#.#.......
..#.....#......##.###..........
.........#...................#.
..........#...#.#....##........
..#...##....#....#.......#...##
#......#.....#...#...#...#.....
....##...#.#.......#.#...##....
...#.....#....#.....#....#.....
#....##.....##..##..........##.
.....#.....#.#.#...............
.#.##....#.....#.#..#....#..##.
.....#.#.....##....#...........
.........#..#.......##..##.....
..#....##.....###...#....#.#...
............#......#.#...#..#..
#..##......#.#.##....#.#.......
.#.#.....#...#.#.#....#.....#..
#....#..#.#....#...#...........
......#.#.....#...#.#.#......#.
###..#....#.###.............#..
..............#####........###.
..#..#.#.#.#......#......#.....
###.........#.#..........#..#.#
.#.........#...#......####.....
..#.......####..#....#...#..#..
#.#..#.#...............#.#.#.#.
###....#.....##.#....#......##.
..#..#........#....###.#.#.....
...#.#..........#.....#...#....
....#......##.#............#..#
...##...#.....#..##....#..#.#.#
.......#.....#..#....#....##.#.
.#..#....#..#......##....##...#
..#......#...#.#..###..#.##....
#...#.....#......##...#.......#
.....#.#.....#...##............
.#..##.##..#..##.#........#....
....#.#......##...#.#.#.#..##..
.#..............##........#....
.##....#..#..#....#...#......#.
............###....##.......##.
..............####.....#.......
........##..##.#...#.......#...
....#..#.....##.......#####...#
.##..##..#.....#...#..#..#....#
##..#.#.#...........#..........
#..#......#...#....#...........
...#..##.#..........#..#.......
........#.#.....#......##......
.....#....#............#.......
.#.#..#....##......#.......###.
.#..#.#........#......#...##..#
...#....#......#..#........#.##
.........#..#...#..#.#.##......
....###.#...........#...#......
.##............#.......#..##...
##...#.#...............#.#...##
..#..#.....#.#..#..#...........
..#..#.##..#......#.##..#.#....
..#...#......#.#...#....##.#...
...###....####......#....#...#.
.......##........#.....##....#.
.........##..........#...#.....
.....#............#.##.#....#.#
..........#...#....##..........
....................#......#...
#......#..#...#.............##.
...........#...................
..#...#.........#.##.#..##.#...
#.#....#.#.....#............#..
.#..#.....#.....####......#.#..
#....#.......##..#...........#.
............#...#.....#..#.#...
#...........#...#####....#...#.
..........#...###..##.........#
#.....###............#..#..#.#.
...##.....#....#......#.....#..
#....#.......#..#......###...#.
...##.##......##..##..........#
.......#.#..#.#..#.#.#.#..#..#.
..#..###...#....#.....#......#.
...#.........#..#.##.#.....###.
..#.........#.##.#..#..#..###..
..####..#.........#.........#.#
..#.#...#.......#....##........
.#......#.#....................
..........#.......#.#..#..#....
..#........#....#.#..#.........
..#.....#.............#....#...
##...#.........#.....#...#.....";

            #endregion
            
            var strings = inputReal.Split("\r\n");

            long treesCounter2 = 0;

            for (int i = 0, right = 0; i < strings.Length; i++, right += 3)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter2++;
            }

            long treesCounter1 = 0;

            for (int i = 0, right = 0; i < strings.Length; i++, right += 1)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter1++;
            }
            
            long treesCounter3 = 0;

            for (int i = 0, right = 0; i < strings.Length; i++, right += 5)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter3++;
            }
            
            long treesCounter4 = 0;

            for (int i = 0, right = 0; i < strings.Length; i++, right += 7)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter4++;
            }
            
            long treesCounter5 = 0;

            for (int i = 0, right = 0; i < strings.Length; i += 2, right += 1)
            {
                if (right >= strings[i].Length)
                {
                    var givenString = strings[i];
                    while (right >= strings[i].Length)
                    {
                        strings[i] += givenString;
                    }                    
                }

                if (strings[i][right] == '#')
                    treesCounter5++;
            }

            long answer = treesCounter1 * treesCounter2 * treesCounter3 * treesCounter4 * treesCounter5; 
            Console.ReadLine();
        }
        
        private static void Task_4_1()
        {
            #region MyRegion
                var input = $@"iyr:2015 cid:189 ecl:oth byr:1947 hcl:#6c4ab1 eyr:2026
hgt:174cm
pid:526744288

pid:688706448 iyr:2017 hgt:162cm cid:174 ecl:grn byr:1943 hcl:#808e9e eyr:2025

ecl:oth hcl:#733820 cid:124 pid:111220591
iyr:2019 eyr:2001
byr:1933 hgt:159in

pid:812929897 hgt:159cm hcl:#fffffd byr:1942 iyr:2026 cid:291
ecl:oth
eyr:2024

cid:83 pid:524032739 iyr:2013 ecl:amb byr:1974
hgt:191cm hcl:#ceb3a1 eyr:2028

ecl:gry hcl:eefed5 pid:88405792 hgt:183cm cid:221 byr:1963 eyr:2029

pid:777881168 ecl:grn
hgt:181cm byr:1923 eyr:2021 iyr:2018 hcl:#18171d

byr:1941 eyr:2027 ecl:gry iyr:2016 pid:062495008 hcl:#a5e1b5 hgt:178cm

cid:56
byr:1971
hcl:#efcc98 pid:649868696 iyr:2011 eyr:2025 hgt:164cm

ecl:blu
pid:117915262 eyr:2023 byr:1925 iyr:2020 hcl:#888785
hgt:188cm

iyr:2012
cid:174
eyr:2024
pid:143293382 ecl:brn byr:1946 hgt:193cm

eyr:2021 iyr:2011
hgt:192cm pid:251564680
byr:1976
ecl:blu hcl:#602927

byr:1973 ecl:blu hgt:164cm
eyr:2022 pid:695538656 iyr:2010 cid:244 hcl:#b6652a

iyr:2014
eyr:2027 pid:358398181 ecl:hzl hgt:74in byr:1949 cid:329
hcl:#ceb3a1

cid:211
byr:1954 eyr:2023 hgt:172cm ecl:blu iyr:2019 hcl:#623a2f pid:657051725

pid:562699115 eyr:2026 byr:2000
hgt:162cm hcl:#602927 ecl:amb iyr:2018

ecl:brn
iyr:2013
pid:835184859 byr:1981 hgt:157cm eyr:2027 hcl:#b6652a

pid:763432667 byr:1981 hcl:#cfa07d ecl:brn
iyr:2010 hgt:63in cid:107
eyr:2027

byr:2009
hgt:177cm cid:314
hcl:f55bf8 eyr:2025
pid:632519974
iyr:2015 ecl:amb

eyr:2024 pid:614239656 hgt:169cm iyr:2014 ecl:hzl byr:1992
hcl:#602927

ecl:blu
eyr:2026
hcl:#efcc98
byr:1980 iyr:2013
hgt:161cm
pid:065413599

hgt:182cm
eyr:2025 iyr:2013 pid:939088351 hcl:#b6652a byr:1994 ecl:amb

hgt:65in cid:220 ecl:amb hcl:#ceb3a1
iyr:2013 eyr:2025 pid:167894964 byr:1976

hgt:185cm cid:88 ecl:blu iyr:2020
eyr:2020
hcl:#888785 pid:582683387
byr:1981

hcl:#866857 eyr:2020 byr:1948
pid:358943355
ecl:amb hgt:164cm iyr:2019

pid:127467714
hcl:#ceb3a1 byr:1991 hgt:163cm eyr:2020 iyr:2017 ecl:blu cid:229

cid:156 byr:1942 eyr:2024 hcl:#cfa07d
ecl:blu pid:843747591
iyr:2014 hgt:173cm

hcl:#a97842 hgt:165cm
iyr:2013 ecl:#781088 byr:1952
pid:516882944
eyr:2026

hgt:179cm
byr:1969 pid:408297435 iyr:2020 ecl:oth hcl:#cfa07d eyr:2020

ecl:amb iyr:2013 hcl:#b6652a eyr:2023 cid:88
pid:324081998 hgt:66in byr:1945

iyr:2012
eyr:2024
hcl:#18171d
pid:756726480 byr:1947 ecl:oth
hgt:164cm

ecl:blu
hcl:#fffffd byr:1951 iyr:2019 pid:544645775
hgt:153cm eyr:2027

pid:655906238 ecl:brn eyr:2028 byr:1959 hgt:63in cid:338
iyr:2020

eyr:2020
hcl:#602927 hgt:72in iyr:2014
pid:305025767
cid:297 byr:1957 ecl:gry

hgt:155cm byr:1942 hcl:#a97842
iyr:2014 ecl:gry pid:593995708
eyr:2022

pid:219206471 byr:1955 eyr:2030
hcl:#a97842 ecl:oth iyr:2015 cid:134 hgt:170cm

iyr:2013 cid:268
eyr:2020
hcl:#a97842 ecl:grn pid:235279200 hgt:178cm
byr:1952

iyr:2013 pid:016384352 eyr:2027
hcl:#866857 ecl:grn hgt:161cm byr:1943

ecl:amb hgt:169cm pid:149540593
iyr:2012
eyr:2040 hcl:#a97842 byr:1954

byr:1938
ecl:brn hcl:#b6652a eyr:2026 hgt:184cm iyr:2018 pid:832531235

byr:1945 iyr:2015 hgt:171cm eyr:2028 pid:998746896 ecl:hzl hcl:#866857

hgt:73in ecl:hzl eyr:2023 cid:343 pid:458004221 iyr:2017 byr:1962 hcl:#efcc98

byr:1970 hgt:159cm pid:925022199 iyr:2013
eyr:2028 hcl:#888785
ecl:hzl

eyr:2027 iyr:2016 ecl:gry
hcl:#cfa07d
pid:006246552 byr:1939 cid:124 hgt:177cm

byr:1982
iyr:2016 hgt:159cm
cid:102 hcl:#fffffd
eyr:2029
ecl:grn pid:619798285

iyr:2018
hgt:189cm hcl:#efcc98
byr:1937 eyr:2023 pid:727551553 ecl:oth

iyr:2014 byr:1976
eyr:2020 hcl:#7d3b0c pid:125102070 ecl:amb
hgt:186cm

hgt:187cm byr:1949
pid:027653233 eyr:2021 hcl:#341e13 ecl:hzl
iyr:2020

iyr:2016
byr:1954 pid:545631256
hcl:#602927 eyr:2023
hgt:191cm ecl:amb

pid:509762954
hgt:190cm ecl:hzl byr:1991
eyr:2022 iyr:2019
cid:187

hcl:#c0946f eyr:2024 hgt:152cm cid:277 iyr:2015 pid:872373191 byr:1988

pid:544267207 cid:113
iyr:2015
hgt:181cm
hcl:#6b5442
ecl:gry
byr:1971

ecl:gry
hgt:161cm iyr:2012 byr:1965
pid:574527322 hcl:#fffffd

iyr:2018 byr:1976 hcl:#b6652a
pid:024582079 hgt:169cm ecl:oth eyr:2021

pid:020478204
byr:1945 hcl:#7d3b0c
cid:239 eyr:2025 hgt:188cm
ecl:grn
iyr:2012

eyr:2026 pid:202653345
byr:1988
hcl:#2cdc09
hgt:185cm iyr:2010
ecl:hzl

hgt:183cm iyr:2017
hcl:#18171d byr:1977 eyr:2029 pid:804559436 ecl:grn

hcl:#602927 pid:812072269 hgt:170cm eyr:2026 byr:1955 iyr:2020 ecl:gry

eyr:2023 iyr:2010
hcl:#cfa07d pid:592419048 byr:1943
ecl:brn
hgt:172cm

ecl:brn iyr:2013 pid:558179058
hcl:#fffffd eyr:2022
byr:1922
cid:331 hgt:64in

ecl:xry
hcl:ade850 eyr:1995 pid:976028541
iyr:2030 hgt:179cm
byr:2030

ecl:#2872b1 pid:158cm eyr:1927 hcl:ee8e92
iyr:2014 hgt:190cm
byr:2025

hgt:155cm cid:283 eyr:2020 ecl:blu pid:755165290 byr:1936 hcl:#733820 iyr:2012

eyr:2030
byr:1943
cid:323 pid:906418061 hgt:157cm ecl:amb iyr:2010
hcl:#7d3b0c

hcl:#fffffd
pid:873200829 hgt:192cm eyr:2022 ecl:blu iyr:2016 byr:1920 cid:200

eyr:2021
byr:1963
hcl:#a97842 pid:585551405
iyr:2019 cid:91
ecl:brn hgt:60cm

byr:1946
pid:520273609 hcl:#341e13 cid:66
iyr:2020 hgt:154cm eyr:2024
ecl:brn

ecl:brn hcl:#d64d7b eyr:2020
byr:1957 hgt:181cm iyr:2019 pid:378496967 cid:135

pid:002446580
eyr:2027 byr:1939 hcl:#888785
iyr:2011 cid:168
ecl:oth hgt:160cm

iyr:2019 hgt:70in hcl:#7d3b0c byr:1983
eyr:2024 pid:369493064 cid:54 ecl:oth

iyr:1979 pid:170cm
hgt:65cm eyr:1933 hcl:z

ecl:zzz pid:193cm hcl:z eyr:2020 byr:2013 iyr:2016 hgt:177in

iyr:2010 hgt:187cm
byr:1932
hcl:z ecl:oth pid:665967850 eyr:2030

eyr:2029
iyr:2013 hcl:#b6652a ecl:amb
byr:1936 pid:516025566
hgt:181cm

hcl:#c0946f pid:238825672 byr:2000
iyr:2013 eyr:2028 ecl:amb hgt:183cm

eyr:2021 hcl:#866857
cid:77 iyr:2017 hgt:156cm pid:271118829 ecl:amb

iyr:2014
hcl:#fffffd
cid:321 hgt:159cm ecl:gry
pid:691381062 eyr:2022 byr:1991

pid:111506492 hcl:#c1d296 iyr:2011
byr:1934 hgt:176cm cid:263 eyr:2028 ecl:amb

iyr:2014 hgt:64in eyr:2024 cid:193 hcl:#b6652a byr:1967
ecl:oth pid:138677174

hgt:168cm iyr:2020 eyr:2030
hcl:#6b5442 ecl:brn pid:975843892 byr:1927

byr:1957 ecl:amb iyr:2012 pid:177266671 eyr:2026
hcl:#866857 hgt:162cm

eyr:2029
hcl:#341e13
hgt:175cm pid:465809700 ecl:amb byr:1974
iyr:2010

hcl:#a97842 iyr:2010
hgt:176cm eyr:2029 byr:1931 ecl:grt pid:161604244

eyr:2024 iyr:2018 hgt:170in byr:1959 ecl:gmt hcl:#888785
pid:94163132

iyr:2011
hgt:186cm pid:998471478 byr:1956 ecl:amb
eyr:2029
hcl:#efcc98
cid:76

ecl:brn
byr:2001 pid:378527883 iyr:2013 hcl:#83bdc5 eyr:2020 hgt:181cm

iyr:2017 ecl:grn hgt:172cm hcl:#888785 cid:100
eyr:2022 byr:2030
pid:311562177

pid:097558436
cid:141 hgt:152cm iyr:2019
ecl:brn eyr:2023
byr:1940
hcl:#6b5442

iyr:2016 eyr:2023 byr:1992
hgt:174cm ecl:amb
pid:691291640 cid:190 hcl:#fffffd

hcl:#623a2f ecl:brn
eyr:2028 cid:227 iyr:2012 hgt:74in pid:964273950 byr:1965

hcl:#ceb3a1 eyr:2028
iyr:2013 pid:175294029 hgt:150cm ecl:grn
byr:1936
cid:143

byr:1935 hcl:#a97842 ecl:oth hgt:180cm iyr:2019
pid:857891916
eyr:2026

pid:084518249 ecl:hzl eyr:2027 hcl:#c0946f hgt:192cm cid:315 byr:1961
iyr:2010

hgt:67cm pid:37925169 eyr:2022
hcl:z iyr:2012 cid:315 byr:2028 ecl:dne

hcl:#c0946f byr:1924
hgt:176cm cid:87 pid:682212551 iyr:2011
eyr:2026
ecl:gry

hgt:181cm byr:1935
iyr:2018 pid:644964785
eyr:2026 ecl:amb

pid:789810179
ecl:gry eyr:2021
cid:159 hgt:185cm iyr:2020 hcl:#602927
byr:1965

pid:672386364
iyr:2013 eyr:2021 byr:1951 hcl:#341e13
ecl:gry hgt:173cm

hcl:#18171d eyr:2030 pid:957722245 iyr:2012 byr:1955
ecl:grn
hgt:154cm

byr:1955 ecl:oth
hcl:#cfa07d
eyr:2030
iyr:2013 pid:361945273 hgt:154cm

iyr:2012 eyr:2027 ecl:grn hcl:#16d373
hgt:192cm

pid:275525273
byr:1986
iyr:2017
eyr:2022
ecl:grn
hgt:75in
hcl:#919cc0

eyr:2029
cid:84 hcl:#cfa07d iyr:2013 hgt:78
ecl:brn
byr:1925 pid:281331549

eyr:2027
cid:219 iyr:2016 byr:1971 hcl:#7d3b0c hgt:179cm ecl:grn
pid:301296222

eyr:2030 iyr:2010 pid:995982765
byr:1926 ecl:amb hcl:#888785 hgt:186cm

byr:1955 iyr:2015 hgt:165cm cid:101
eyr:2027 ecl:amb hcl:#602927
pid:168654790

hcl:#7d3b0c byr:1956 eyr:2029 hgt:155cm
ecl:grn pid:816685992
iyr:2016

ecl:grn hcl:#cfa07d cid:71
pid:914724136 iyr:2012 eyr:2024
hgt:184cm byr:1938

ecl:gry
eyr:2029 hcl:#602927 pid:255062643 iyr:2015 hgt:175cm

hcl:#341e13 iyr:2017 eyr:2028
pid:459704815 byr:1922
cid:312
ecl:brn hgt:152cm

ecl:dne eyr:1981
pid:8356519470 hgt:176 iyr:1941 byr:2006 hcl:z

ecl:amb pid:753377589 hcl:#a97842 eyr:2022 hgt:187cm
cid:130 iyr:2013 byr:1961

pid:952444443
hcl:#bde835 byr:1963 iyr:2020 eyr:2025
ecl:amb hgt:162cm

eyr:2027 iyr:2018 hcl:#ceb3a1 hgt:152cm pid:882429463 ecl:blu byr:1969

cid:134 eyr:2021 hcl:#a97842 hgt:63in
ecl:grn byr:1975 iyr:2019 pid:154078695

byr:1956 eyr:2027
pid:396230480 hcl:#b6652a
hgt:175cm iyr:2020 ecl:oth

ecl:grn
cid:263 hcl:#506937 byr:1924
eyr:2030 pid:705511368 hgt:159cm
iyr:2011

eyr:2020 hgt:178cm ecl:grn
byr:1947 hcl:#888785
pid:177476829 iyr:2019

ecl:hzl cid:211 iyr:2016 hgt:176cm pid:405182470
byr:1952
hcl:#866857 eyr:2028

eyr:2032 cid:152 ecl:gmt hgt:150in
pid:75969209
byr:2019 hcl:z iyr:1940

hcl:#fffffd hgt:193cm pid:607407479 cid:300 byr:1944 iyr:2017
ecl:oth
eyr:2026

hcl:z
cid:125 eyr:2040 ecl:dne byr:2015 pid:733096171 hgt:63cm
iyr:1922

pid:575721428 hgt:152cm cid:275
hcl:#cfa07d eyr:2028
byr:1935 ecl:hzl iyr:2016

iyr:2012
ecl:grn eyr:2027 hcl:#623a2f pid:029106453 byr:1984 hgt:168cm

ecl:blu cid:140 eyr:2028 iyr:2018 hcl:#c0946f
hgt:163cm byr:1944
pid:709288293

byr:1936
hgt:172cm eyr:1997 hcl:#8b8c88 cid:50
iyr:2016 pid:205477922 ecl:grn

hgt:170cm pid:872750582 eyr:2027 byr:1985 iyr:2017 hcl:#d6976a ecl:blu

hgt:163cm
pid:189634089 cid:116 byr:1975 eyr:2030
hcl:#efcc98 ecl:brn iyr:2020

ecl:amb byr:1953 hcl:#6b5442 pid:418787965
iyr:2018 hgt:193cm
eyr:2026

ecl:#3ec898 cid:339 hcl:#866857 eyr:2025 hgt:179cm pid:591430028 iyr:1936 byr:1995

pid:285371937 hgt:159cm
byr:1922
iyr:2013 eyr:2023 hcl:#6b5442 ecl:amb

pid:545260883 ecl:oth
hgt:163cm
iyr:2015 eyr:2021 byr:1975 hcl:#866857

ecl:hzl hgt:182cm pid:053762098 eyr:2023 cid:174 hcl:#6daac4 iyr:2017 byr:1937

hgt:178cm iyr:2015 byr:1956 pid:815359103
ecl:blu hcl:#cfa07d eyr:2030

hcl:#7d3b0c
pid:438108851 hgt:162cm byr:1930 iyr:2014 eyr:2024 ecl:amb

eyr:2027 iyr:2019 hcl:#90eb1c hgt:178cm
pid:314810594 cid:278 ecl:amb
byr:2001

byr:1949 iyr:1942 hcl:#888785 ecl:hzl hgt:184cm eyr:2027 pid:899137640

hgt:153cm
eyr:2022 iyr:2011 byr:1975
hcl:#602927
ecl:amb pid:178cm

hcl:#6b5442
ecl:amb iyr:2018 eyr:2025 pid:418735327 byr:1922 hgt:74in

ecl:gmt hcl:z iyr:2024
eyr:1988 hgt:75cm cid:125 pid:690872200 byr:1928

eyr:2024 hgt:184cm
pid:4634589837 ecl:zzz iyr:2022 byr:2000 hcl:89c187

iyr:2017 byr:1966 hcl:#efcc98 ecl:brn pid:473085232 eyr:2021 hgt:174cm

hgt:67in eyr:2030 iyr:2014 byr:1943 hcl:#602927 cid:344
ecl:oth
pid:210476779

byr:1955
ecl:oth
hgt:193cm iyr:2012 hcl:#623a2f pid:818289829 eyr:2021

byr:2018 ecl:#872a51 iyr:2024 hcl:97783d
pid:155cm hgt:174cm
eyr:1964

hcl:#6b5442 hgt:157cm byr:1932 ecl:brn pid:4275535874
eyr:2024 iyr:2015

pid:959861097
hgt:151cm cid:140 byr:1935
eyr:2029
iyr:2018 ecl:hzl
hcl:#623a2f

hgt:181cm pid:911791767 eyr:2027
iyr:2016 byr:1962
ecl:grn hcl:#866857

eyr:2021
byr:1994
hgt:162cm hcl:#866857 ecl:oth iyr:2014
pid:712345689

hcl:#7d3b0c
hgt:170cm pid:600132416 eyr:2025
iyr:2016 byr:1978 ecl:brn

hcl:#0a9307
cid:287 byr:1940 pid:786271493
eyr:2028 hgt:186cm
iyr:2019 ecl:oth

eyr:2025 hgt:190cm ecl:hzl cid:228 iyr:2019
byr:1932
hcl:#623a2f pid:648307551

pid:304587325 iyr:2019 byr:1923 hcl:#7d3b0c
hgt:190cm
ecl:gry eyr:2030

hgt:188cm eyr:2027 byr:1958 pid:572934921
hcl:#888785 ecl:hzl iyr:2010

iyr:2019
hgt:178cm ecl:grn hcl:#7d3b0c pid:007601227
byr:1975 eyr:2023

pid:808872803 byr:1929
ecl:grn
eyr:2022 iyr:2019 hgt:74in hcl:#602927

iyr:2019
cid:67 hcl:#602927 pid:292601338 ecl:hzl
byr:2001 eyr:2023 hgt:171cm

byr:1962 eyr:2022 hcl:#b6652a hgt:193cm
ecl:oth
iyr:2010

hgt:70in iyr:2014 hcl:#a97842
cid:169 eyr:2020 ecl:amb
pid:329751670 byr:1959

byr:1920
ecl:oth hgt:172cm cid:57 pid:515139276
eyr:2030
hcl:#18171d
iyr:2013

iyr:2012
hcl:#a97842 pid:946040810 hgt:65in
byr:1936 ecl:amb eyr:2020

byr:1948 hcl:#18171d
iyr:2019
ecl:hzl cid:185
eyr:2023
pid:583625200 hgt:191cm

hgt:154cm eyr:2022
pid:460137392 iyr:2010
ecl:grn
hcl:#ceb3a1

eyr:2024
iyr:2016 pid:890698391 hgt:172cm hcl:#a97842 cid:271 ecl:oth byr:1926

hgt:162cm pid:340904964 hcl:#b6652a
byr:1966
iyr:2010
cid:260 eyr:2028
ecl:amb

byr:1933 eyr:2029 pid:642043350
iyr:2016 hcl:#b6652a ecl:grn

pid:602218620 eyr:2023 ecl:blu
hcl:#623a2f
byr:1950 hgt:168cm iyr:2015

ecl:gry pid:490792384
byr:1974
hcl:#a97842 iyr:2016 hgt:170cm

iyr:2020 ecl:gry byr:2002
eyr:2029 hcl:#9f45c4
hgt:155cm pid:604239618

hgt:190cm pid:560653271 iyr:2020 cid:349
eyr:2024 ecl:blu hcl:#efcc98 byr:1936

eyr:2021 byr:1964 hcl:#efcc98 ecl:grn iyr:2018
hgt:165cm pid:218376636

pid:186217101
iyr:2019 hgt:155cm
byr:2017 eyr:2022 ecl:grn cid:349 hcl:ece72e

iyr:2015
eyr:2026 pid:802832833
hcl:#888785 hgt:190cm ecl:brn
byr:1952
cid:202

cid:151 iyr:2017 hgt:152cm hcl:#a97842 eyr:2020 ecl:hzl
pid:554959609 byr:1941

cid:116
iyr:2019 hgt:159cm byr:1992 pid:662111811
hcl:#18171d ecl:oth eyr:2024

ecl:grn byr:1966
iyr:1950 pid:585351486
eyr:2038 hgt:178in hcl:a27d2b

iyr:2014 cid:238 hgt:187cm pid:523401750 ecl:amb hcl:#18171d eyr:2023 byr:1984

eyr:2021 byr:1957
pid:340752324
iyr:2015 hgt:157cm
hcl:#602927 cid:70
ecl:oth

pid:458479816 ecl:hzl
eyr:2022 hcl:z
hgt:60cm
byr:2012 iyr:2005

cid:57
hgt:154cm pid:446142864
hcl:#341e13 byr:1968 eyr:2030
iyr:2019
ecl:brn

eyr:2028
pid:243811429 byr:1977
iyr:2011 hcl:#18171d hgt:185cm ecl:oth

cid:205 byr:1976 eyr:2029 pid:649877471 hcl:#cfa07d hgt:152cm
ecl:blu
iyr:2013

iyr:2009 pid:559014976 ecl:oth hgt:189cm byr:1936 eyr:2037
hcl:#efcc98

pid:134378987 byr:1983 iyr:2013 hgt:173cm
ecl:oth hcl:#ceb3a1
cid:80
eyr:2020

hgt:151cm byr:1964 ecl:grn iyr:2010 hcl:#b6652a pid:939492531
eyr:2028

byr:1961 iyr:2014 hcl:#733820 hgt:179cm
eyr:2026 ecl:gry pid:732892920

iyr:2018 byr:1996
pid:944007809 ecl:hzl
hcl:#866857 eyr:2021
hgt:155cm

pid:374875696 hcl:#7d3b0c
ecl:oth
hgt:193cm byr:1948 cid:238
iyr:2020

pid:305782299 hcl:#b6652a
ecl:brn
hgt:172cm
iyr:2018 byr:1927

pid:945869114 cid:95 byr:1989 hgt:173cm eyr:2025 hcl:#b6652a iyr:2012 ecl:amb

pid:55484149
eyr:1958
iyr:1956 ecl:grn
cid:95 byr:2028
hcl:c2af7e

hgt:176cm ecl:amb
hcl:#a97842 eyr:2029 pid:937928270
cid:251
byr:1978
iyr:2018

hgt:154cm
cid:213 pid:767329807 ecl:hzl
iyr:2013
hcl:#888785
eyr:2026 byr:1998

cid:158 hcl:#b6652a hgt:155cm iyr:2010 eyr:2025
byr:1980 pid:338567803 ecl:amb

hcl:#efcc98 byr:1940 hgt:62in ecl:oth pid:537307591
eyr:2030
iyr:2017
cid:179

byr:1965 eyr:2027 pid:691913618 hgt:75in
hcl:#6b5442 ecl:gry iyr:2012

hgt:163cm byr:1964 eyr:2025
iyr:2010 hcl:#ceb3a1 ecl:oth
pid:936536544

pid:712946803
cid:343
hgt:187cm ecl:oth iyr:2020 byr:1983 eyr:2030
hcl:#7873b3

ecl:blu
iyr:2010
hcl:#fffffd
eyr:2030
hgt:175cm pid:047567505 byr:1963

ecl:gry byr:1946 eyr:2026 hcl:#602927
hgt:164cm
iyr:2010

pid:223378458
iyr:2014 cid:151 ecl:hzl hgt:171cm
eyr:2020
hcl:#341e13 byr:1964

ecl:brn byr:1948
hcl:#866857
hgt:193cm eyr:2024
iyr:2013 cid:277

hcl:#623a2f byr:1943 iyr:2011 ecl:oth
hgt:184cm
pid:371604584 eyr:2024 cid:176

hcl:#efcc98
eyr:2025 pid:241834382
hgt:178cm
byr:1985
iyr:2017

hcl:#c0946f
byr:1996 pid:701366586 eyr:2026 hgt:163cm iyr:2015 ecl:oth

hgt:65cm hcl:#18171d
eyr:2024 ecl:brn pid:172cm
iyr:2010
byr:1990

hcl:#fffffd pid:68659204 hgt:161cm iyr:2025
ecl:#94b8aa byr:2021 eyr:2032

ecl:blu iyr:2018 byr:1993 cid:184
hgt:177cm pid:289871693 hcl:#733820 eyr:2026

cid:138
ecl:gry hgt:174cm eyr:2024 byr:1988 iyr:2014 hcl:#341e13 pid:864852584

cid:321 eyr:2028 pid:93285596 hgt:173cm
iyr:2013 ecl:gry hcl:#623a2f
byr:1927

pid:431242259 eyr:2022 ecl:hzl
byr:1960 hgt:151cm hcl:#efcc98 iyr:2020

hcl:#866857 eyr:2029 iyr:2016 ecl:grn pid:526060780 byr:1929
cid:310 hgt:162cm

ecl:blu hgt:183cm cid:168
iyr:2015
eyr:2021 byr:1951 hcl:#6b5442
pid:594960553

hcl:#ceb3a1
iyr:2020 byr:1951 hgt:186cm eyr:2022 ecl:amb pid:317661479

iyr:2016
hgt:163in hcl:#accfa0
ecl:brn
pid:307377995 byr:2000 eyr:2028

pid:933380459
byr:1938
cid:291 hcl:#c0946f
ecl:oth iyr:2018
eyr:2026 hgt:170cm

byr:1974
pid:262927116 eyr:2027 ecl:gry
hcl:#341e13 iyr:2014 cid:232 hgt:161cm

hcl:#602927
byr:2001 iyr:2011
hgt:177cm eyr:2028 pid:165733929 ecl:amb

byr:1922 cid:144 pid:333716867 hgt:183cm iyr:2015
hcl:#c25ea9 eyr:2022 ecl:blu

eyr:2021 cid:147 byr:1978
iyr:2020 pid:938828535
hcl:#7d3b0c ecl:amb hgt:159cm

hgt:153cm ecl:hzl
cid:232 byr:1953 hcl:#a97842 iyr:2016 pid:356632792 eyr:2029

pid:745727684 ecl:gry iyr:2020
hcl:#a97842
eyr:2025 cid:275
hgt:65in
byr:1957

hcl:#733820
ecl:grn iyr:2019 byr:1943 eyr:2024 hgt:70in
pid:953607814

ecl:gry eyr:2028 hcl:#cfa07d
hgt:163cm
byr:1942 iyr:2019 pid:310104177

hgt:190cm
eyr:2027 iyr:2010 byr:1978
ecl:gry
hcl:#964ba7

cid:320
eyr:2022 hgt:169cm
ecl:blu hcl:#a97842 iyr:2015 pid:669007078 byr:1986

iyr:2019 pid:901370677 hcl:7f2398 cid:305
ecl:amb eyr:2011 hgt:190cm byr:1991

ecl:brn
cid:256 byr:1987 iyr:2017 eyr:2026 hcl:#623a2f pid:875646528
hgt:160cm

byr:1955 pid:120131971 hcl:#18171d
hgt:156cm
ecl:blu
iyr:2011 eyr:2028

iyr:2020 ecl:brn cid:188
hgt:157cm
eyr:2026
pid:504067323 hcl:#733820 byr:1982

cid:102 hgt:177cm
hcl:#733820 ecl:hzl byr:1984 pid:542750146 eyr:2028 iyr:2020

pid:419639528 iyr:2013 hgt:175cm ecl:blu
eyr:2026 byr:1999 hcl:#733820

byr:1963 eyr:2020
pid:683641152 ecl:gry cid:207 hgt:180cm
hcl:#cfa07d
iyr:2020

hgt:192cm pid:156436859 iyr:2020 hcl:#cfa07d
ecl:blu byr:1963 eyr:2025 cid:147

eyr:2002
hcl:z iyr:2011
pid:6830168962
hgt:156in cid:288 byr:2029

eyr:2021
pid:277739802 byr:1992 ecl:hzl iyr:2020
hcl:#7c5fe8 hgt:184cm

byr:1989 pid:066973099
iyr:2017
eyr:2022 ecl:hzl hcl:#888785 hgt:76in

hcl:#866857
iyr:2016 cid:306
ecl:hzl
pid:453816800 byr:1971 hgt:71in eyr:2030

pid:248573931 hcl:#cfa07d
iyr:2014 eyr:2024 hgt:186cm byr:1970 cid:128 ecl:blu

pid:172567579 ecl:brn iyr:2014 byr:1948 cid:309
hgt:151cm hcl:#888785 eyr:2024

hgt:153cm eyr:2026 byr:1929 ecl:hzl pid:684760742
hcl:#c45e93 iyr:2018

pid:#d50a43
iyr:1940
ecl:#7880a9 byr:2018 hcl:dc2fa7 hgt:185in eyr:1978

hcl:#602927 cid:71 eyr:2020
pid:620634584 hgt:157cm byr:1991
iyr:2020 ecl:amb

eyr:2023
byr:1959 iyr:1947 hgt:152cm ecl:#503286 pid:63978523 hcl:57dd0d

hgt:190cm
byr:1955 ecl:blu
pid:507892696
hcl:#9bd1f0 eyr:2029
iyr:2010

pid:365539813
eyr:2022 hcl:#623a2f iyr:2020 hgt:184cm
ecl:oth byr:1920 cid:213

cid:50 ecl:oth pid:774859218 hgt:193cm
iyr:2017 byr:1925 hcl:#866857
eyr:2021

hgt:189cm
iyr:2019 byr:1937
hcl:#a97842
eyr:2025 ecl:oth
pid:787390180

iyr:2019 eyr:2027 hgt:183cm
ecl:hzl pid:549757712
byr:1956
hcl:#866857

pid:755580715
hcl:#602927 hgt:187cm iyr:2017 byr:1925 eyr:2020 ecl:blu

iyr:2019 hgt:69in
ecl:amb
hcl:#602927 eyr:2026
pid:951019647 byr:1974

byr:1943 eyr:2034 hgt:150 pid:#36aedf ecl:oth
hcl:z

eyr:2024
ecl:hzl pid:824745692 iyr:2012 hcl:06ab6e
byr:1944
hgt:159cm
cid:183

hgt:169cm ecl:blu
eyr:2030 iyr:2013 byr:1945 pid:791359040 hcl:#7d3b0c

iyr:2018
ecl:hzl hgt:152cm
hcl:#18171d eyr:2026 byr:1924 pid:534667048

eyr:2029 pid:933295825
iyr:2011
hcl:#cfa07d byr:1981
hgt:164cm ecl:grn

ecl:amb byr:1964 iyr:2018
pid:014457573
cid:152
eyr:2028 hgt:171cm hcl:#866857

hgt:167cm
byr:1974 iyr:2012 ecl:amb pid:512315114
cid:278
eyr:2028 hcl:#623a2f

hgt:153cm ecl:oth iyr:2012
eyr:2027 hcl:#888785 byr:1999 pid:416990697

eyr:2025 ecl:blu byr:1991 hcl:#866857
hgt:189cm pid:546461828

iyr:2016
byr:1988
hgt:160cm eyr:2025 ecl:amb hcl:#602927
pid:562766105

ecl:oth byr:1942
hcl:#341e13 pid:564975864 cid:158
hgt:159cm eyr:2028
iyr:2018

pid:406209763 hgt:170cm cid:331
iyr:2018 eyr:2026 byr:1981
hcl:#733820 ecl:gry

pid:279164109 ecl:oth
cid:197 hcl:#7d3b0c
eyr:2024
hgt:185cm iyr:2020 byr:1925

hcl:#efcc98 ecl:hzl
cid:92 hgt:190cm pid:724466265 iyr:2020
eyr:2025 byr:1996

byr:1996
cid:55 pid:906572505 ecl:grn eyr:2022 hcl:#602927 hgt:160cm iyr:2014

eyr:2028 hcl:#b6652a ecl:hzl hgt:186cm iyr:2016 pid:132872161 byr:1932

hcl:#fffffd iyr:2019 eyr:2020 hgt:188cm
byr:1951 ecl:brn
pid:842126902

hcl:#602927
hgt:158cm
eyr:2023 iyr:2010
pid:681061896 byr:1977 ecl:gry

iyr:2018 hgt:192cm byr:1970 cid:200 ecl:grn eyr:2027
pid:164408694 hcl:#888785

eyr:2029
pid:447061655 iyr:2010 hcl:#341e13 ecl:oth
cid:187 hgt:185cm byr:1943

byr:1925 iyr:2012 eyr:2025
hgt:190cm hcl:#18171d pid:017534154 ecl:brn

hgt:172cm byr:1923
eyr:2026 iyr:2015
pid:580812884 hcl:#c0946f ecl:hzl

hcl:#888785 eyr:2028
byr:1952 ecl:brn pid:818889983
iyr:2010 hgt:180cm

eyr:2026 ecl:gry byr:1982 hgt:188cm hcl:#c0946f pid:610689703 iyr:2011

eyr:2028
iyr:2018
pid:921660781 ecl:amb
hcl:#cfa07d hgt:178cm byr:1975

byr:1977 pid:667631009 iyr:2010
cid:86 eyr:2022 hgt:189cm hcl:#7d3b0c ecl:oth

pid:214679440 hgt:190cm ecl:blu iyr:2017
eyr:2025 cid:292

ecl:amb
iyr:2017 hcl:531ad3
hgt:163 pid:689027667 byr:2006 eyr:2033

hgt:68in byr:1928 iyr:2010 cid:227 eyr:2023
ecl:hzl pid:#87bab9 hcl:#fffffd

ecl:grn byr:1940 cid:294 hgt:152cm pid:310277488
iyr:2015 hcl:#18171d eyr:2030

byr:1965 pid:240720987
eyr:2030 ecl:oth hgt:192cm hcl:#733820
iyr:2016

pid:830487275
ecl:blu byr:1930
hcl:#b6652a iyr:2013 hgt:188cm eyr:2025

hgt:177cm byr:1955 eyr:2030 ecl:amb pid:476675886 iyr:2016 hcl:#c0946f

pid:152702068 iyr:2016 hcl:#b6652a
cid:82 ecl:blu eyr:2029 byr:1975 hgt:161cm

pid:136852264
eyr:2024 cid:339 ecl:oth byr:1949 iyr:2011

iyr:2020 pid:772739059
eyr:2025 hgt:157cm
byr:1945 ecl:brn
hcl:#6b5442

hcl:#18171d eyr:2022
iyr:2018 ecl:grn byr:1933 pid:053763751

pid:214212776 hcl:#18171d
eyr:2030
iyr:2020 byr:1988
cid:122
hgt:170cm ecl:oth

pid:883116919 iyr:2018 ecl:brn byr:1938 hgt:187cm eyr:2020

iyr:2020 hcl:#a97842
cid:329 eyr:2025 byr:1946 pid:636649774
ecl:grn hgt:158cm

eyr:2023
ecl:blu hgt:161cm
hcl:#341e13 byr:1951
iyr:2020 pid:461889565 cid:97

hgt:168cm pid:492241189
eyr:2029
iyr:2013
cid:150
byr:1980 hcl:#cfa07d ecl:hzl

byr:1998 ecl:gry hgt:150cm eyr:2024 pid:401735295 cid:153 hcl:#733820 iyr:2016

ecl:hzl hgt:184cm iyr:2018
byr:2001
pid:453480077 eyr:2025 hcl:#a97842";
            #endregion

            var counter = 0;

            var cut_strings = input.Split("\r\n\r\n");

            foreach (var VARIABLE in cut_strings)
            {
                var passport_data = VARIABLE.Split("\r\n");
                var fields = passport_data.Select(x => x.Split(" ")).SelectMany(x => x).ToList();
                if(fields.Count == 8 || 
                   (fields.Count == 7 && !fields.Any(x => x.StartsWith("cid:"))))
                {
                    counter++;
                }
                

            }
            
            Console.ReadLine();
        }
        
        private static void Task_4_2()
        {
            #region MyRegion
                var input = $@"iyr:2015 cid:189 ecl:oth byr:1947 hcl:#6c4ab1 eyr:2026
hgt:174cm
pid:526744288

pid:688706448 iyr:2017 hgt:162cm cid:174 ecl:grn byr:1943 hcl:#808e9e eyr:2025

ecl:oth hcl:#733820 cid:124 pid:111220591
iyr:2019 eyr:2001
byr:1933 hgt:159in

pid:812929897 hgt:159cm hcl:#fffffd byr:1942 iyr:2026 cid:291
ecl:oth
eyr:2024

cid:83 pid:524032739 iyr:2013 ecl:amb byr:1974
hgt:191cm hcl:#ceb3a1 eyr:2028

ecl:gry hcl:eefed5 pid:88405792 hgt:183cm cid:221 byr:1963 eyr:2029

pid:777881168 ecl:grn
hgt:181cm byr:1923 eyr:2021 iyr:2018 hcl:#18171d

byr:1941 eyr:2027 ecl:gry iyr:2016 pid:062495008 hcl:#a5e1b5 hgt:178cm

cid:56
byr:1971
hcl:#efcc98 pid:649868696 iyr:2011 eyr:2025 hgt:164cm

ecl:blu
pid:117915262 eyr:2023 byr:1925 iyr:2020 hcl:#888785
hgt:188cm

iyr:2012
cid:174
eyr:2024
pid:143293382 ecl:brn byr:1946 hgt:193cm

eyr:2021 iyr:2011
hgt:192cm pid:251564680
byr:1976
ecl:blu hcl:#602927

byr:1973 ecl:blu hgt:164cm
eyr:2022 pid:695538656 iyr:2010 cid:244 hcl:#b6652a

iyr:2014
eyr:2027 pid:358398181 ecl:hzl hgt:74in byr:1949 cid:329
hcl:#ceb3a1

cid:211
byr:1954 eyr:2023 hgt:172cm ecl:blu iyr:2019 hcl:#623a2f pid:657051725

pid:562699115 eyr:2026 byr:2000
hgt:162cm hcl:#602927 ecl:amb iyr:2018

ecl:brn
iyr:2013
pid:835184859 byr:1981 hgt:157cm eyr:2027 hcl:#b6652a

pid:763432667 byr:1981 hcl:#cfa07d ecl:brn
iyr:2010 hgt:63in cid:107
eyr:2027

byr:2009
hgt:177cm cid:314
hcl:f55bf8 eyr:2025
pid:632519974
iyr:2015 ecl:amb

eyr:2024 pid:614239656 hgt:169cm iyr:2014 ecl:hzl byr:1992
hcl:#602927

ecl:blu
eyr:2026
hcl:#efcc98
byr:1980 iyr:2013
hgt:161cm
pid:065413599

hgt:182cm
eyr:2025 iyr:2013 pid:939088351 hcl:#b6652a byr:1994 ecl:amb

hgt:65in cid:220 ecl:amb hcl:#ceb3a1
iyr:2013 eyr:2025 pid:167894964 byr:1976

hgt:185cm cid:88 ecl:blu iyr:2020
eyr:2020
hcl:#888785 pid:582683387
byr:1981

hcl:#866857 eyr:2020 byr:1948
pid:358943355
ecl:amb hgt:164cm iyr:2019

pid:127467714
hcl:#ceb3a1 byr:1991 hgt:163cm eyr:2020 iyr:2017 ecl:blu cid:229

cid:156 byr:1942 eyr:2024 hcl:#cfa07d
ecl:blu pid:843747591
iyr:2014 hgt:173cm

hcl:#a97842 hgt:165cm
iyr:2013 ecl:#781088 byr:1952
pid:516882944
eyr:2026

hgt:179cm
byr:1969 pid:408297435 iyr:2020 ecl:oth hcl:#cfa07d eyr:2020

ecl:amb iyr:2013 hcl:#b6652a eyr:2023 cid:88
pid:324081998 hgt:66in byr:1945

iyr:2012
eyr:2024
hcl:#18171d
pid:756726480 byr:1947 ecl:oth
hgt:164cm

ecl:blu
hcl:#fffffd byr:1951 iyr:2019 pid:544645775
hgt:153cm eyr:2027

pid:655906238 ecl:brn eyr:2028 byr:1959 hgt:63in cid:338
iyr:2020

eyr:2020
hcl:#602927 hgt:72in iyr:2014
pid:305025767
cid:297 byr:1957 ecl:gry

hgt:155cm byr:1942 hcl:#a97842
iyr:2014 ecl:gry pid:593995708
eyr:2022

pid:219206471 byr:1955 eyr:2030
hcl:#a97842 ecl:oth iyr:2015 cid:134 hgt:170cm

iyr:2013 cid:268
eyr:2020
hcl:#a97842 ecl:grn pid:235279200 hgt:178cm
byr:1952

iyr:2013 pid:016384352 eyr:2027
hcl:#866857 ecl:grn hgt:161cm byr:1943

ecl:amb hgt:169cm pid:149540593
iyr:2012
eyr:2040 hcl:#a97842 byr:1954

byr:1938
ecl:brn hcl:#b6652a eyr:2026 hgt:184cm iyr:2018 pid:832531235

byr:1945 iyr:2015 hgt:171cm eyr:2028 pid:998746896 ecl:hzl hcl:#866857

hgt:73in ecl:hzl eyr:2023 cid:343 pid:458004221 iyr:2017 byr:1962 hcl:#efcc98

byr:1970 hgt:159cm pid:925022199 iyr:2013
eyr:2028 hcl:#888785
ecl:hzl

eyr:2027 iyr:2016 ecl:gry
hcl:#cfa07d
pid:006246552 byr:1939 cid:124 hgt:177cm

byr:1982
iyr:2016 hgt:159cm
cid:102 hcl:#fffffd
eyr:2029
ecl:grn pid:619798285

iyr:2018
hgt:189cm hcl:#efcc98
byr:1937 eyr:2023 pid:727551553 ecl:oth

iyr:2014 byr:1976
eyr:2020 hcl:#7d3b0c pid:125102070 ecl:amb
hgt:186cm

hgt:187cm byr:1949
pid:027653233 eyr:2021 hcl:#341e13 ecl:hzl
iyr:2020

iyr:2016
byr:1954 pid:545631256
hcl:#602927 eyr:2023
hgt:191cm ecl:amb

pid:509762954
hgt:190cm ecl:hzl byr:1991
eyr:2022 iyr:2019
cid:187

hcl:#c0946f eyr:2024 hgt:152cm cid:277 iyr:2015 pid:872373191 byr:1988

pid:544267207 cid:113
iyr:2015
hgt:181cm
hcl:#6b5442
ecl:gry
byr:1971

ecl:gry
hgt:161cm iyr:2012 byr:1965
pid:574527322 hcl:#fffffd

iyr:2018 byr:1976 hcl:#b6652a
pid:024582079 hgt:169cm ecl:oth eyr:2021

pid:020478204
byr:1945 hcl:#7d3b0c
cid:239 eyr:2025 hgt:188cm
ecl:grn
iyr:2012

eyr:2026 pid:202653345
byr:1988
hcl:#2cdc09
hgt:185cm iyr:2010
ecl:hzl

hgt:183cm iyr:2017
hcl:#18171d byr:1977 eyr:2029 pid:804559436 ecl:grn

hcl:#602927 pid:812072269 hgt:170cm eyr:2026 byr:1955 iyr:2020 ecl:gry

eyr:2023 iyr:2010
hcl:#cfa07d pid:592419048 byr:1943
ecl:brn
hgt:172cm

ecl:brn iyr:2013 pid:558179058
hcl:#fffffd eyr:2022
byr:1922
cid:331 hgt:64in

ecl:xry
hcl:ade850 eyr:1995 pid:976028541
iyr:2030 hgt:179cm
byr:2030

ecl:#2872b1 pid:158cm eyr:1927 hcl:ee8e92
iyr:2014 hgt:190cm
byr:2025

hgt:155cm cid:283 eyr:2020 ecl:blu pid:755165290 byr:1936 hcl:#733820 iyr:2012

eyr:2030
byr:1943
cid:323 pid:906418061 hgt:157cm ecl:amb iyr:2010
hcl:#7d3b0c

hcl:#fffffd
pid:873200829 hgt:192cm eyr:2022 ecl:blu iyr:2016 byr:1920 cid:200

eyr:2021
byr:1963
hcl:#a97842 pid:585551405
iyr:2019 cid:91
ecl:brn hgt:60cm

byr:1946
pid:520273609 hcl:#341e13 cid:66
iyr:2020 hgt:154cm eyr:2024
ecl:brn

ecl:brn hcl:#d64d7b eyr:2020
byr:1957 hgt:181cm iyr:2019 pid:378496967 cid:135

pid:002446580
eyr:2027 byr:1939 hcl:#888785
iyr:2011 cid:168
ecl:oth hgt:160cm

iyr:2019 hgt:70in hcl:#7d3b0c byr:1983
eyr:2024 pid:369493064 cid:54 ecl:oth

iyr:1979 pid:170cm
hgt:65cm eyr:1933 hcl:z

ecl:zzz pid:193cm hcl:z eyr:2020 byr:2013 iyr:2016 hgt:177in

iyr:2010 hgt:187cm
byr:1932
hcl:z ecl:oth pid:665967850 eyr:2030

eyr:2029
iyr:2013 hcl:#b6652a ecl:amb
byr:1936 pid:516025566
hgt:181cm

hcl:#c0946f pid:238825672 byr:2000
iyr:2013 eyr:2028 ecl:amb hgt:183cm

eyr:2021 hcl:#866857
cid:77 iyr:2017 hgt:156cm pid:271118829 ecl:amb

iyr:2014
hcl:#fffffd
cid:321 hgt:159cm ecl:gry
pid:691381062 eyr:2022 byr:1991

pid:111506492 hcl:#c1d296 iyr:2011
byr:1934 hgt:176cm cid:263 eyr:2028 ecl:amb

iyr:2014 hgt:64in eyr:2024 cid:193 hcl:#b6652a byr:1967
ecl:oth pid:138677174

hgt:168cm iyr:2020 eyr:2030
hcl:#6b5442 ecl:brn pid:975843892 byr:1927

byr:1957 ecl:amb iyr:2012 pid:177266671 eyr:2026
hcl:#866857 hgt:162cm

eyr:2029
hcl:#341e13
hgt:175cm pid:465809700 ecl:amb byr:1974
iyr:2010

hcl:#a97842 iyr:2010
hgt:176cm eyr:2029 byr:1931 ecl:grt pid:161604244

eyr:2024 iyr:2018 hgt:170in byr:1959 ecl:gmt hcl:#888785
pid:94163132

iyr:2011
hgt:186cm pid:998471478 byr:1956 ecl:amb
eyr:2029
hcl:#efcc98
cid:76

ecl:brn
byr:2001 pid:378527883 iyr:2013 hcl:#83bdc5 eyr:2020 hgt:181cm

iyr:2017 ecl:grn hgt:172cm hcl:#888785 cid:100
eyr:2022 byr:2030
pid:311562177

pid:097558436
cid:141 hgt:152cm iyr:2019
ecl:brn eyr:2023
byr:1940
hcl:#6b5442

iyr:2016 eyr:2023 byr:1992
hgt:174cm ecl:amb
pid:691291640 cid:190 hcl:#fffffd

hcl:#623a2f ecl:brn
eyr:2028 cid:227 iyr:2012 hgt:74in pid:964273950 byr:1965

hcl:#ceb3a1 eyr:2028
iyr:2013 pid:175294029 hgt:150cm ecl:grn
byr:1936
cid:143

byr:1935 hcl:#a97842 ecl:oth hgt:180cm iyr:2019
pid:857891916
eyr:2026

pid:084518249 ecl:hzl eyr:2027 hcl:#c0946f hgt:192cm cid:315 byr:1961
iyr:2010

hgt:67cm pid:37925169 eyr:2022
hcl:z iyr:2012 cid:315 byr:2028 ecl:dne

hcl:#c0946f byr:1924
hgt:176cm cid:87 pid:682212551 iyr:2011
eyr:2026
ecl:gry

hgt:181cm byr:1935
iyr:2018 pid:644964785
eyr:2026 ecl:amb

pid:789810179
ecl:gry eyr:2021
cid:159 hgt:185cm iyr:2020 hcl:#602927
byr:1965

pid:672386364
iyr:2013 eyr:2021 byr:1951 hcl:#341e13
ecl:gry hgt:173cm

hcl:#18171d eyr:2030 pid:957722245 iyr:2012 byr:1955
ecl:grn
hgt:154cm

byr:1955 ecl:oth
hcl:#cfa07d
eyr:2030
iyr:2013 pid:361945273 hgt:154cm

iyr:2012 eyr:2027 ecl:grn hcl:#16d373
hgt:192cm

pid:275525273
byr:1986
iyr:2017
eyr:2022
ecl:grn
hgt:75in
hcl:#919cc0

eyr:2029
cid:84 hcl:#cfa07d iyr:2013 hgt:78
ecl:brn
byr:1925 pid:281331549

eyr:2027
cid:219 iyr:2016 byr:1971 hcl:#7d3b0c hgt:179cm ecl:grn
pid:301296222

eyr:2030 iyr:2010 pid:995982765
byr:1926 ecl:amb hcl:#888785 hgt:186cm

byr:1955 iyr:2015 hgt:165cm cid:101
eyr:2027 ecl:amb hcl:#602927
pid:168654790

hcl:#7d3b0c byr:1956 eyr:2029 hgt:155cm
ecl:grn pid:816685992
iyr:2016

ecl:grn hcl:#cfa07d cid:71
pid:914724136 iyr:2012 eyr:2024
hgt:184cm byr:1938

ecl:gry
eyr:2029 hcl:#602927 pid:255062643 iyr:2015 hgt:175cm

hcl:#341e13 iyr:2017 eyr:2028
pid:459704815 byr:1922
cid:312
ecl:brn hgt:152cm

ecl:dne eyr:1981
pid:8356519470 hgt:176 iyr:1941 byr:2006 hcl:z

ecl:amb pid:753377589 hcl:#a97842 eyr:2022 hgt:187cm
cid:130 iyr:2013 byr:1961

pid:952444443
hcl:#bde835 byr:1963 iyr:2020 eyr:2025
ecl:amb hgt:162cm

eyr:2027 iyr:2018 hcl:#ceb3a1 hgt:152cm pid:882429463 ecl:blu byr:1969

cid:134 eyr:2021 hcl:#a97842 hgt:63in
ecl:grn byr:1975 iyr:2019 pid:154078695

byr:1956 eyr:2027
pid:396230480 hcl:#b6652a
hgt:175cm iyr:2020 ecl:oth

ecl:grn
cid:263 hcl:#506937 byr:1924
eyr:2030 pid:705511368 hgt:159cm
iyr:2011

eyr:2020 hgt:178cm ecl:grn
byr:1947 hcl:#888785
pid:177476829 iyr:2019

ecl:hzl cid:211 iyr:2016 hgt:176cm pid:405182470
byr:1952
hcl:#866857 eyr:2028

eyr:2032 cid:152 ecl:gmt hgt:150in
pid:75969209
byr:2019 hcl:z iyr:1940

hcl:#fffffd hgt:193cm pid:607407479 cid:300 byr:1944 iyr:2017
ecl:oth
eyr:2026

hcl:z
cid:125 eyr:2040 ecl:dne byr:2015 pid:733096171 hgt:63cm
iyr:1922

pid:575721428 hgt:152cm cid:275
hcl:#cfa07d eyr:2028
byr:1935 ecl:hzl iyr:2016

iyr:2012
ecl:grn eyr:2027 hcl:#623a2f pid:029106453 byr:1984 hgt:168cm

ecl:blu cid:140 eyr:2028 iyr:2018 hcl:#c0946f
hgt:163cm byr:1944
pid:709288293

byr:1936
hgt:172cm eyr:1997 hcl:#8b8c88 cid:50
iyr:2016 pid:205477922 ecl:grn

hgt:170cm pid:872750582 eyr:2027 byr:1985 iyr:2017 hcl:#d6976a ecl:blu

hgt:163cm
pid:189634089 cid:116 byr:1975 eyr:2030
hcl:#efcc98 ecl:brn iyr:2020

ecl:amb byr:1953 hcl:#6b5442 pid:418787965
iyr:2018 hgt:193cm
eyr:2026

ecl:#3ec898 cid:339 hcl:#866857 eyr:2025 hgt:179cm pid:591430028 iyr:1936 byr:1995

pid:285371937 hgt:159cm
byr:1922
iyr:2013 eyr:2023 hcl:#6b5442 ecl:amb

pid:545260883 ecl:oth
hgt:163cm
iyr:2015 eyr:2021 byr:1975 hcl:#866857

ecl:hzl hgt:182cm pid:053762098 eyr:2023 cid:174 hcl:#6daac4 iyr:2017 byr:1937

hgt:178cm iyr:2015 byr:1956 pid:815359103
ecl:blu hcl:#cfa07d eyr:2030

hcl:#7d3b0c
pid:438108851 hgt:162cm byr:1930 iyr:2014 eyr:2024 ecl:amb

eyr:2027 iyr:2019 hcl:#90eb1c hgt:178cm
pid:314810594 cid:278 ecl:amb
byr:2001

byr:1949 iyr:1942 hcl:#888785 ecl:hzl hgt:184cm eyr:2027 pid:899137640

hgt:153cm
eyr:2022 iyr:2011 byr:1975
hcl:#602927
ecl:amb pid:178cm

hcl:#6b5442
ecl:amb iyr:2018 eyr:2025 pid:418735327 byr:1922 hgt:74in

ecl:gmt hcl:z iyr:2024
eyr:1988 hgt:75cm cid:125 pid:690872200 byr:1928

eyr:2024 hgt:184cm
pid:4634589837 ecl:zzz iyr:2022 byr:2000 hcl:89c187

iyr:2017 byr:1966 hcl:#efcc98 ecl:brn pid:473085232 eyr:2021 hgt:174cm

hgt:67in eyr:2030 iyr:2014 byr:1943 hcl:#602927 cid:344
ecl:oth
pid:210476779

byr:1955
ecl:oth
hgt:193cm iyr:2012 hcl:#623a2f pid:818289829 eyr:2021

byr:2018 ecl:#872a51 iyr:2024 hcl:97783d
pid:155cm hgt:174cm
eyr:1964

hcl:#6b5442 hgt:157cm byr:1932 ecl:brn pid:4275535874
eyr:2024 iyr:2015

pid:959861097
hgt:151cm cid:140 byr:1935
eyr:2029
iyr:2018 ecl:hzl
hcl:#623a2f

hgt:181cm pid:911791767 eyr:2027
iyr:2016 byr:1962
ecl:grn hcl:#866857

eyr:2021
byr:1994
hgt:162cm hcl:#866857 ecl:oth iyr:2014
pid:712345689

hcl:#7d3b0c
hgt:170cm pid:600132416 eyr:2025
iyr:2016 byr:1978 ecl:brn

hcl:#0a9307
cid:287 byr:1940 pid:786271493
eyr:2028 hgt:186cm
iyr:2019 ecl:oth

eyr:2025 hgt:190cm ecl:hzl cid:228 iyr:2019
byr:1932
hcl:#623a2f pid:648307551

pid:304587325 iyr:2019 byr:1923 hcl:#7d3b0c
hgt:190cm
ecl:gry eyr:2030

hgt:188cm eyr:2027 byr:1958 pid:572934921
hcl:#888785 ecl:hzl iyr:2010

iyr:2019
hgt:178cm ecl:grn hcl:#7d3b0c pid:007601227
byr:1975 eyr:2023

pid:808872803 byr:1929
ecl:grn
eyr:2022 iyr:2019 hgt:74in hcl:#602927

iyr:2019
cid:67 hcl:#602927 pid:292601338 ecl:hzl
byr:2001 eyr:2023 hgt:171cm

byr:1962 eyr:2022 hcl:#b6652a hgt:193cm
ecl:oth
iyr:2010

hgt:70in iyr:2014 hcl:#a97842
cid:169 eyr:2020 ecl:amb
pid:329751670 byr:1959

byr:1920
ecl:oth hgt:172cm cid:57 pid:515139276
eyr:2030
hcl:#18171d
iyr:2013

iyr:2012
hcl:#a97842 pid:946040810 hgt:65in
byr:1936 ecl:amb eyr:2020

byr:1948 hcl:#18171d
iyr:2019
ecl:hzl cid:185
eyr:2023
pid:583625200 hgt:191cm

hgt:154cm eyr:2022
pid:460137392 iyr:2010
ecl:grn
hcl:#ceb3a1

eyr:2024
iyr:2016 pid:890698391 hgt:172cm hcl:#a97842 cid:271 ecl:oth byr:1926

hgt:162cm pid:340904964 hcl:#b6652a
byr:1966
iyr:2010
cid:260 eyr:2028
ecl:amb

byr:1933 eyr:2029 pid:642043350
iyr:2016 hcl:#b6652a ecl:grn

pid:602218620 eyr:2023 ecl:blu
hcl:#623a2f
byr:1950 hgt:168cm iyr:2015

ecl:gry pid:490792384
byr:1974
hcl:#a97842 iyr:2016 hgt:170cm

iyr:2020 ecl:gry byr:2002
eyr:2029 hcl:#9f45c4
hgt:155cm pid:604239618

hgt:190cm pid:560653271 iyr:2020 cid:349
eyr:2024 ecl:blu hcl:#efcc98 byr:1936

eyr:2021 byr:1964 hcl:#efcc98 ecl:grn iyr:2018
hgt:165cm pid:218376636

pid:186217101
iyr:2019 hgt:155cm
byr:2017 eyr:2022 ecl:grn cid:349 hcl:ece72e

iyr:2015
eyr:2026 pid:802832833
hcl:#888785 hgt:190cm ecl:brn
byr:1952
cid:202

cid:151 iyr:2017 hgt:152cm hcl:#a97842 eyr:2020 ecl:hzl
pid:554959609 byr:1941

cid:116
iyr:2019 hgt:159cm byr:1992 pid:662111811
hcl:#18171d ecl:oth eyr:2024

ecl:grn byr:1966
iyr:1950 pid:585351486
eyr:2038 hgt:178in hcl:a27d2b

iyr:2014 cid:238 hgt:187cm pid:523401750 ecl:amb hcl:#18171d eyr:2023 byr:1984

eyr:2021 byr:1957
pid:340752324
iyr:2015 hgt:157cm
hcl:#602927 cid:70
ecl:oth

pid:458479816 ecl:hzl
eyr:2022 hcl:z
hgt:60cm
byr:2012 iyr:2005

cid:57
hgt:154cm pid:446142864
hcl:#341e13 byr:1968 eyr:2030
iyr:2019
ecl:brn

eyr:2028
pid:243811429 byr:1977
iyr:2011 hcl:#18171d hgt:185cm ecl:oth

cid:205 byr:1976 eyr:2029 pid:649877471 hcl:#cfa07d hgt:152cm
ecl:blu
iyr:2013

iyr:2009 pid:559014976 ecl:oth hgt:189cm byr:1936 eyr:2037
hcl:#efcc98

pid:134378987 byr:1983 iyr:2013 hgt:173cm
ecl:oth hcl:#ceb3a1
cid:80
eyr:2020

hgt:151cm byr:1964 ecl:grn iyr:2010 hcl:#b6652a pid:939492531
eyr:2028

byr:1961 iyr:2014 hcl:#733820 hgt:179cm
eyr:2026 ecl:gry pid:732892920

iyr:2018 byr:1996
pid:944007809 ecl:hzl
hcl:#866857 eyr:2021
hgt:155cm

pid:374875696 hcl:#7d3b0c
ecl:oth
hgt:193cm byr:1948 cid:238
iyr:2020

pid:305782299 hcl:#b6652a
ecl:brn
hgt:172cm
iyr:2018 byr:1927

pid:945869114 cid:95 byr:1989 hgt:173cm eyr:2025 hcl:#b6652a iyr:2012 ecl:amb

pid:55484149
eyr:1958
iyr:1956 ecl:grn
cid:95 byr:2028
hcl:c2af7e

hgt:176cm ecl:amb
hcl:#a97842 eyr:2029 pid:937928270
cid:251
byr:1978
iyr:2018

hgt:154cm
cid:213 pid:767329807 ecl:hzl
iyr:2013
hcl:#888785
eyr:2026 byr:1998

cid:158 hcl:#b6652a hgt:155cm iyr:2010 eyr:2025
byr:1980 pid:338567803 ecl:amb

hcl:#efcc98 byr:1940 hgt:62in ecl:oth pid:537307591
eyr:2030
iyr:2017
cid:179

byr:1965 eyr:2027 pid:691913618 hgt:75in
hcl:#6b5442 ecl:gry iyr:2012

hgt:163cm byr:1964 eyr:2025
iyr:2010 hcl:#ceb3a1 ecl:oth
pid:936536544

pid:712946803
cid:343
hgt:187cm ecl:oth iyr:2020 byr:1983 eyr:2030
hcl:#7873b3

ecl:blu
iyr:2010
hcl:#fffffd
eyr:2030
hgt:175cm pid:047567505 byr:1963

ecl:gry byr:1946 eyr:2026 hcl:#602927
hgt:164cm
iyr:2010

pid:223378458
iyr:2014 cid:151 ecl:hzl hgt:171cm
eyr:2020
hcl:#341e13 byr:1964

ecl:brn byr:1948
hcl:#866857
hgt:193cm eyr:2024
iyr:2013 cid:277

hcl:#623a2f byr:1943 iyr:2011 ecl:oth
hgt:184cm
pid:371604584 eyr:2024 cid:176

hcl:#efcc98
eyr:2025 pid:241834382
hgt:178cm
byr:1985
iyr:2017

hcl:#c0946f
byr:1996 pid:701366586 eyr:2026 hgt:163cm iyr:2015 ecl:oth

hgt:65cm hcl:#18171d
eyr:2024 ecl:brn pid:172cm
iyr:2010
byr:1990

hcl:#fffffd pid:68659204 hgt:161cm iyr:2025
ecl:#94b8aa byr:2021 eyr:2032

ecl:blu iyr:2018 byr:1993 cid:184
hgt:177cm pid:289871693 hcl:#733820 eyr:2026

cid:138
ecl:gry hgt:174cm eyr:2024 byr:1988 iyr:2014 hcl:#341e13 pid:864852584

cid:321 eyr:2028 pid:93285596 hgt:173cm
iyr:2013 ecl:gry hcl:#623a2f
byr:1927

pid:431242259 eyr:2022 ecl:hzl
byr:1960 hgt:151cm hcl:#efcc98 iyr:2020

hcl:#866857 eyr:2029 iyr:2016 ecl:grn pid:526060780 byr:1929
cid:310 hgt:162cm

ecl:blu hgt:183cm cid:168
iyr:2015
eyr:2021 byr:1951 hcl:#6b5442
pid:594960553

hcl:#ceb3a1
iyr:2020 byr:1951 hgt:186cm eyr:2022 ecl:amb pid:317661479

iyr:2016
hgt:163in hcl:#accfa0
ecl:brn
pid:307377995 byr:2000 eyr:2028

pid:933380459
byr:1938
cid:291 hcl:#c0946f
ecl:oth iyr:2018
eyr:2026 hgt:170cm

byr:1974
pid:262927116 eyr:2027 ecl:gry
hcl:#341e13 iyr:2014 cid:232 hgt:161cm

hcl:#602927
byr:2001 iyr:2011
hgt:177cm eyr:2028 pid:165733929 ecl:amb

byr:1922 cid:144 pid:333716867 hgt:183cm iyr:2015
hcl:#c25ea9 eyr:2022 ecl:blu

eyr:2021 cid:147 byr:1978
iyr:2020 pid:938828535
hcl:#7d3b0c ecl:amb hgt:159cm

hgt:153cm ecl:hzl
cid:232 byr:1953 hcl:#a97842 iyr:2016 pid:356632792 eyr:2029

pid:745727684 ecl:gry iyr:2020
hcl:#a97842
eyr:2025 cid:275
hgt:65in
byr:1957

hcl:#733820
ecl:grn iyr:2019 byr:1943 eyr:2024 hgt:70in
pid:953607814

ecl:gry eyr:2028 hcl:#cfa07d
hgt:163cm
byr:1942 iyr:2019 pid:310104177

hgt:190cm
eyr:2027 iyr:2010 byr:1978
ecl:gry
hcl:#964ba7

cid:320
eyr:2022 hgt:169cm
ecl:blu hcl:#a97842 iyr:2015 pid:669007078 byr:1986

iyr:2019 pid:901370677 hcl:7f2398 cid:305
ecl:amb eyr:2011 hgt:190cm byr:1991

ecl:brn
cid:256 byr:1987 iyr:2017 eyr:2026 hcl:#623a2f pid:875646528
hgt:160cm

byr:1955 pid:120131971 hcl:#18171d
hgt:156cm
ecl:blu
iyr:2011 eyr:2028

iyr:2020 ecl:brn cid:188
hgt:157cm
eyr:2026
pid:504067323 hcl:#733820 byr:1982

cid:102 hgt:177cm
hcl:#733820 ecl:hzl byr:1984 pid:542750146 eyr:2028 iyr:2020

pid:419639528 iyr:2013 hgt:175cm ecl:blu
eyr:2026 byr:1999 hcl:#733820

byr:1963 eyr:2020
pid:683641152 ecl:gry cid:207 hgt:180cm
hcl:#cfa07d
iyr:2020

hgt:192cm pid:156436859 iyr:2020 hcl:#cfa07d
ecl:blu byr:1963 eyr:2025 cid:147

eyr:2002
hcl:z iyr:2011
pid:6830168962
hgt:156in cid:288 byr:2029

eyr:2021
pid:277739802 byr:1992 ecl:hzl iyr:2020
hcl:#7c5fe8 hgt:184cm

byr:1989 pid:066973099
iyr:2017
eyr:2022 ecl:hzl hcl:#888785 hgt:76in

hcl:#866857
iyr:2016 cid:306
ecl:hzl
pid:453816800 byr:1971 hgt:71in eyr:2030

pid:248573931 hcl:#cfa07d
iyr:2014 eyr:2024 hgt:186cm byr:1970 cid:128 ecl:blu

pid:172567579 ecl:brn iyr:2014 byr:1948 cid:309
hgt:151cm hcl:#888785 eyr:2024

hgt:153cm eyr:2026 byr:1929 ecl:hzl pid:684760742
hcl:#c45e93 iyr:2018

pid:#d50a43
iyr:1940
ecl:#7880a9 byr:2018 hcl:dc2fa7 hgt:185in eyr:1978

hcl:#602927 cid:71 eyr:2020
pid:620634584 hgt:157cm byr:1991
iyr:2020 ecl:amb

eyr:2023
byr:1959 iyr:1947 hgt:152cm ecl:#503286 pid:63978523 hcl:57dd0d

hgt:190cm
byr:1955 ecl:blu
pid:507892696
hcl:#9bd1f0 eyr:2029
iyr:2010

pid:365539813
eyr:2022 hcl:#623a2f iyr:2020 hgt:184cm
ecl:oth byr:1920 cid:213

cid:50 ecl:oth pid:774859218 hgt:193cm
iyr:2017 byr:1925 hcl:#866857
eyr:2021

hgt:189cm
iyr:2019 byr:1937
hcl:#a97842
eyr:2025 ecl:oth
pid:787390180

iyr:2019 eyr:2027 hgt:183cm
ecl:hzl pid:549757712
byr:1956
hcl:#866857

pid:755580715
hcl:#602927 hgt:187cm iyr:2017 byr:1925 eyr:2020 ecl:blu

iyr:2019 hgt:69in
ecl:amb
hcl:#602927 eyr:2026
pid:951019647 byr:1974

byr:1943 eyr:2034 hgt:150 pid:#36aedf ecl:oth
hcl:z

eyr:2024
ecl:hzl pid:824745692 iyr:2012 hcl:06ab6e
byr:1944
hgt:159cm
cid:183

hgt:169cm ecl:blu
eyr:2030 iyr:2013 byr:1945 pid:791359040 hcl:#7d3b0c

iyr:2018
ecl:hzl hgt:152cm
hcl:#18171d eyr:2026 byr:1924 pid:534667048

eyr:2029 pid:933295825
iyr:2011
hcl:#cfa07d byr:1981
hgt:164cm ecl:grn

ecl:amb byr:1964 iyr:2018
pid:014457573
cid:152
eyr:2028 hgt:171cm hcl:#866857

hgt:167cm
byr:1974 iyr:2012 ecl:amb pid:512315114
cid:278
eyr:2028 hcl:#623a2f

hgt:153cm ecl:oth iyr:2012
eyr:2027 hcl:#888785 byr:1999 pid:416990697

eyr:2025 ecl:blu byr:1991 hcl:#866857
hgt:189cm pid:546461828

iyr:2016
byr:1988
hgt:160cm eyr:2025 ecl:amb hcl:#602927
pid:562766105

ecl:oth byr:1942
hcl:#341e13 pid:564975864 cid:158
hgt:159cm eyr:2028
iyr:2018

pid:406209763 hgt:170cm cid:331
iyr:2018 eyr:2026 byr:1981
hcl:#733820 ecl:gry

pid:279164109 ecl:oth
cid:197 hcl:#7d3b0c
eyr:2024
hgt:185cm iyr:2020 byr:1925

hcl:#efcc98 ecl:hzl
cid:92 hgt:190cm pid:724466265 iyr:2020
eyr:2025 byr:1996

byr:1996
cid:55 pid:906572505 ecl:grn eyr:2022 hcl:#602927 hgt:160cm iyr:2014

eyr:2028 hcl:#b6652a ecl:hzl hgt:186cm iyr:2016 pid:132872161 byr:1932

hcl:#fffffd iyr:2019 eyr:2020 hgt:188cm
byr:1951 ecl:brn
pid:842126902

hcl:#602927
hgt:158cm
eyr:2023 iyr:2010
pid:681061896 byr:1977 ecl:gry

iyr:2018 hgt:192cm byr:1970 cid:200 ecl:grn eyr:2027
pid:164408694 hcl:#888785

eyr:2029
pid:447061655 iyr:2010 hcl:#341e13 ecl:oth
cid:187 hgt:185cm byr:1943

byr:1925 iyr:2012 eyr:2025
hgt:190cm hcl:#18171d pid:017534154 ecl:brn

hgt:172cm byr:1923
eyr:2026 iyr:2015
pid:580812884 hcl:#c0946f ecl:hzl

hcl:#888785 eyr:2028
byr:1952 ecl:brn pid:818889983
iyr:2010 hgt:180cm

eyr:2026 ecl:gry byr:1982 hgt:188cm hcl:#c0946f pid:610689703 iyr:2011

eyr:2028
iyr:2018
pid:921660781 ecl:amb
hcl:#cfa07d hgt:178cm byr:1975

byr:1977 pid:667631009 iyr:2010
cid:86 eyr:2022 hgt:189cm hcl:#7d3b0c ecl:oth

pid:214679440 hgt:190cm ecl:blu iyr:2017
eyr:2025 cid:292

ecl:amb
iyr:2017 hcl:531ad3
hgt:163 pid:689027667 byr:2006 eyr:2033

hgt:68in byr:1928 iyr:2010 cid:227 eyr:2023
ecl:hzl pid:#87bab9 hcl:#fffffd

ecl:grn byr:1940 cid:294 hgt:152cm pid:310277488
iyr:2015 hcl:#18171d eyr:2030

byr:1965 pid:240720987
eyr:2030 ecl:oth hgt:192cm hcl:#733820
iyr:2016

pid:830487275
ecl:blu byr:1930
hcl:#b6652a iyr:2013 hgt:188cm eyr:2025

hgt:177cm byr:1955 eyr:2030 ecl:amb pid:476675886 iyr:2016 hcl:#c0946f

pid:152702068 iyr:2016 hcl:#b6652a
cid:82 ecl:blu eyr:2029 byr:1975 hgt:161cm

pid:136852264
eyr:2024 cid:339 ecl:oth byr:1949 iyr:2011

iyr:2020 pid:772739059
eyr:2025 hgt:157cm
byr:1945 ecl:brn
hcl:#6b5442

hcl:#18171d eyr:2022
iyr:2018 ecl:grn byr:1933 pid:053763751

pid:214212776 hcl:#18171d
eyr:2030
iyr:2020 byr:1988
cid:122
hgt:170cm ecl:oth

pid:883116919 iyr:2018 ecl:brn byr:1938 hgt:187cm eyr:2020

iyr:2020 hcl:#a97842
cid:329 eyr:2025 byr:1946 pid:636649774
ecl:grn hgt:158cm

eyr:2023
ecl:blu hgt:161cm
hcl:#341e13 byr:1951
iyr:2020 pid:461889565 cid:97

hgt:168cm pid:492241189
eyr:2029
iyr:2013
cid:150
byr:1980 hcl:#cfa07d ecl:hzl

byr:1998 ecl:gry hgt:150cm eyr:2024 pid:401735295 cid:153 hcl:#733820 iyr:2016

ecl:hzl hgt:184cm iyr:2018
byr:2001
pid:453480077 eyr:2025 hcl:#a97842";
            #endregion

            var counter = 0;

            var cut_strings = input.Split("\r\n\r\n");

            foreach (var VARIABLE in cut_strings)
            {
                var passport_data = VARIABLE.Split("\r\n");
                var fields = passport_data.Select(x => x.Split(" ")).SelectMany(x => x).ToList();
                bool isvalid = true;  
                if(fields.Count == 8 || 
                   (fields.Count == 7 && !fields.Any(x => x.StartsWith("cid:"))))
                {
                    foreach (var x in fields)
                    {
                        if (x.StartsWith("byr:"))
                        {
                            int shit = 0;
                            int.TryParse(x.Split(":")[1], out shit);
                            if (!(shit >= 1920 && shit <= 2002))
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("iyr:"))
                        {
                            int shit = 0;
                            int.TryParse(x.Split(":")[1], out shit);
                            if (!(shit >= 2010 && shit <= 2020))
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("eyr:"))
                        {
                            int shit = 0;
                            int.TryParse(x.Split(":")[1], out shit);
                            if (!(shit >= 2020 && shit <= 2030))
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("hgt:"))
                        {
                            if (x.EndsWith("cm"))
                            {
                                int shit = 0;
                                int.TryParse(x.Split(":")[1].Replace("cm", String.Empty), out shit);
                                if (!(shit >= 150 && shit <= 193))
                                {
                                    isvalid = false;
                                    break;
                                }
                            }
                            else if(x.EndsWith("in"))
                            {
                                int shit = 0;
                                int.TryParse(x.Split(":")[1].Replace("in", String.Empty), out shit);
                                if (!(shit >= 59 && shit <= 76))
                                {
                                    isvalid = false;
                                    break;
                                }
                            }
                            else
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("hcl:"))
                        {
                            Regex regex = new Regex("^#[a-f0-9]{6}$");
                            var rezf = regex.IsMatch(x.Split(":")[1]);
                            if (!rezf)
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("ecl:"))
                        {
                            var huy = x.Split(":")[1];
                            if(!(huy == "amb" ||
                                 huy == "blu" ||
                                 huy == "brn" ||
                                 huy == "gry" ||
                                 huy == "grn" ||
                                 huy == "hzl" ||
                                 huy == "oth"))
                            {
                                isvalid = false;
                                break;
                            }
                        }
                        else if (x.StartsWith("pid:"))
                        {
                            if (!(x.Split(":")[1].All(x => char.IsDigit(x))))
                            {
                                isvalid = false;
                                break;
                            }   
                        }
                    }
                    if (isvalid)
                    {
                        counter++;
                    }
                }
                

            }
            
            Console.ReadLine();
        }

        private static void Task_5_1()
        {
            #region Real Data

            var realInput = $@"BFFBFBFLRL
BFBFBBBLRR
BFBFBFBLRR
BFBFFFFRLR
BBFFBBFRRR
FBBBFFFRLL
FFBFBFFLLL
BBFBFFFRLL
FBBBFFBLRR
FFFFBFFRRL
BFBFBFBRLL
FFBFFBBLLL
BFFBBFFRLR
FBBFFFFLRR
FBFBFFBRRR
FFBFFBBRRR
FBBBFFFRRL
FFBBBBFRRL
BFFBBBBLLL
BFBBFBBLLR
FBBFBFFLLR
FBBFBFFLRR
BFFFFBFLLL
FBBBBBBRRR
FBFFBBFLLR
BBFBFFBRLR
FFFFFBBLLR
FBBFBBBRLL
FFFFBBFRRR
FFFFBFBLRL
FFFBFBFLLR
FFBFBBBLRR
BFFBBBFRLR
FFFBFBBLLL
FBFBBBFLRR
BBFFFBFLLL
FFFFFBBLRR
FFBFBFFRLL
BFFFBBFRLR
BFBBBFBLLR
FFFBBFFLRL
BFBBBFBLLL
FBFBBFBRLR
BBFFBFFRRR
BFFFFBBLRR
FBBBBBFLRL
FBFBBBBRRR
FBFBBFFLLL
BFBBBFBRLL
FFBBFBBLRR
FFBFBBBRRR
FFFFFBFLRL
BFFBBBFLRR
BFBBFBFLLR
FFBFBBBLRL
FBBBBFBLLL
BFBBBFFLRR
FBBFFBBLRR
BFFBBFBLRR
FBBBBBFLLL
FFFFBBBRLR
FBFBBBFLLR
BFBFFBFRLR
BFFBFFBRRR
FBBFFFFLRL
BFBFBBFLRL
BBFBFFFRLR
FBFFFFBLRR
BFFFBFFRLL
FBFFBFBLLR
FFFBFFFRLR
FFFBFFFRLL
BFFBFBBLLL
FFBBFBBLRL
BFBBBBFLRL
BFBBBBFLRR
BFBFFFFRRL
BFBBBFBRLR
BBFFBBBLLR
FBBFBBFRLR
FBFBFBFLLR
BFBFFBBRRR
FFFFBBFLLR
FBFFBFFLLL
BFFFFFBRLR
FBFBBBFLRL
BFFFBBFLLR
FBFBFBBRRR
FBFFBFBLRL
BBFFFBBLLL
FBFFFBFRRL
BBFFFFBRLR
BBFFBFBRRL
BFFBBBBRLR
FBFFFBBLRL
FBBFBBFLLR
FFBBBBBLLL
FBBBBBFLLR
FFBFFBFRLR
BFFBBFBLRL
FFBBBBFRLR
BFFBFBBRRL
FBFBBBFLLL
BBFBFFBRRR
FBFBBFFLLR
BFFFFFBRLL
FBBBBFBLLR
FFBBBFBLRR
FBBBBFBRLR
FBBBBBBRRL
FBBFFFBRRL
FBFBFFFLRR
FBBFFFBRLR
BFFBFBFRRL
FFBFBBFRLL
FBFBFFFRRR
BFFFFBFRRR
FFFFFBFRRL
BBFFBFFLRL
FBBBBBBLLR
BFFFBFFRRR
FFFFFBFRLL
FBBFBFBLLL
FFFFBBFLRR
BFBBFFFRLR
FFBFFBBLRR
FBFFBFBLRR
FFBBBFBLRL
FFFBBFBRLR
BFBFFBBLLR
FFFBBFBLLL
BBFFFBBLRL
FBFBFFFRLR
BBFFBFFRLR
FFFBFBFRLR
FFBBBBFLLR
BBFFBFFLRR
FFFFFBFRLR
BFBFBBFRRR
BBFFFBFRRL
BFFBFBFLLR
FFFBBBBLLL
BFFFBBFLLL
BBFFFBBRRL
BFFFFBFRLL
BFBFBBBLLR
BBFBFFBRRL
FBFFBBFLLL
FBFBFFFRRL
FBBFBBBLRR
BFBBFFBRLL
FBFBBBBRLR
FFFBBFFLRR
FBBFFBFRRL
BFFBBBBLRR
FFFFBBFRLR
FBFBBBFRRR
BFFBFFFRLL
BFFFFFFRRL
FBFFFFBRLR
BFFFFBBRRL
FBBBBBFRLR
FBBBBFBLRR
FFFBBFBRLL
FBBFBBFRRL
FFFBBBBRRL
FBBFFBBRRL
BFFBBFFLLR
FFFBFFBRRL
FBFFBFFLLR
FFFFFFBRLL
FFBBFBBRLR
FFBBFBFLRR
FFFBFFBRRR
FFBFFBBLLR
BFBFBFBLLR
FFBBBBFRRR
BFBBBFBLRL
BFFFBBFRRL
FBFBBBFRLL
BBFFFFBRRR
FBBFBFBRLR
BFBBBFFRRL
FBBBBFBRRL
FBBBFFBLRL
FBFFFBBRRL
BFBBFFBRRL
FBFBBFFLRL
FBFBBBBLRL
FFBBBFBRRL
FBBBBBBLRL
FFFFBBFRLL
FBFBBFBRLL
BFBFBBFLLR
FBFFFBBRLR
BFBFBBBRRR
FBBBBBBLRR
BFFBFFBRRL
FFBBBBBRLR
BFFFBBFLRL
FBFBBBBRLL
FFFFFBFRRR
BFBBBBFRLR
FFBFFBFRRL
FBBBBBBRLR
FBFFFBBLRR
FFFBFFBRLR
BFBFFBFLLR
FFFFFBBRRL
FBBBBBFRRL
FFFFBBBRRR
BFBBFFFRLL
BBFFBFBLLR
FFFFBFFLRR
FBFFFBFLLL
FBBFFBFRLR
BBFBFFBLLR
BBFBFFFLRL
BFFFBBBRLR
BFFBFFBLRL
BFBFBFFLRL
FBBFFBBRLR
FBFBFBBRLL
FFBFFFFLLL
FFFFBFBLLL
FBBFFBBLLR
FFFFBBBLRR
FFFFFBBRRR
BBFFFFFRLL
FBFBBFBRRR
FBBFFFFRRR
FFFFBFBRLR
BFFFFBBLLR
FFFBBBFRLL
BFFBBBBRRR
FBFFBBFRLL
BFBBFBFLRL
FBFBFBBLLL
FFBFFFFRRL
FBFBBBFRRL
FBBBBBBRLL
BFFFBFBRRR
BFBFBFBRRR
FBFFFBBRLL
BFFFFBBLLL
FFFBFFFRRL
FBBBBFFRRL
BFFFFFFLRR
BFBFBFFLRR
BFFFFBBRLL
FBBFFFFRRL
BFBBFBBRRR
FFFBFFBLLR
BFFBFFFRLR
FFBFFFBLLR
BFBFBFBLLL
BFFBFFFLRR
FFBBFFBLRR
FBBFFBFRLL
FFBFBFBRRL
FBFFFFFLLR
FBFFBBFRLR
FBFBBBFRLR
FFBBFFFLRR
FBBFFFFLLL
FFFBFFFLRL
BFFBBFBLLR
BFFFFFBLLL
BBFBFFBLLL
BFFBFBBLRR
BBFFFFBRLL
FBFFBFFLRL
FBBFFFFLLR
FFFBBFFRLR
FFFBBFBLRL
BFFBBBBLLR
BFBBBFBRRL
FFBBBFFLRR
FBBFFBBRLL
FFFBFBBRRR
BFFBFFFLRL
BFFFBFFLLR
FFFBFBFLLL
FFBFBFFRRL
FFFBFFFRRR
BFBFFFFLRL
BFFFFFBRRL
FFFBFBBLRL
FBFFBFFRRL
FFFFBFFLLR
FFBBBBFRLL
FBBBBFFLRR
FFFFBFFLLL
BFBBBBFRRL
FBFBBFFLRR
FFBBFBFRLL
FFFBFBBRLL
BFFFFFFLRL
BBFFFFBLRL
BFFFFFFRLR
FBFFFBFRLR
FBFFFFFLRL
BFBFBFFRLL
FFBBFBFLRL
FFFBBBFLLR
FBBFFFBRRR
FFFFFBFLRR
FBFFFBBLLR
FFFFBFBLRR
FBBFBBBLLR
FBBBFFBLLL
BBFFBFFRRL
BFBBFBBLLL
FBFFBFFRRR
FBFFFFBRLL
FFBBBFBRRR
FBBFFBBLLL
BBFFBBBRLL
FBFFFBFLRR
FBBBFFBRLR
FFBBBBBLLR
FBFFFFBLRL
BFFFBFBRLL
FFFFFBBLRL
BFBBFFBLLL
BBFFBBFLRR
BBFFBFFLLL
FBFBFFBRRL
BFFBBFFRRL
BFFBBFBRRR
FFBBBFBRLL
FBBFBFBRRL
FBFBBFBLLL
BFFFBBBLLL
FFFBBBFLRL
BFBBFFFLRL
FFFBFFBLLL
FFBBFBBRRR
FBBBBFFLLL
BBFBFFFRRR
FFBFFBFLRR
BFFBBFBLLL
BFFFBFBLLR
FFBBFBFRRR
BBFFFBBLRR
FFFFBFFRLL
BFBBBFFRLL
BFBFBFFRRL
BFBFFBBLRR
FBBFFFFRLL
FFFBFBBLLR
BBFFBBBLRR
FFBFBFBRLR
BBFFBBFLRL
BBFFFBBLLR
BFFFBBFLRR
FBBBBFFRLL
FBBFFFBLRR
BFBFBFBRLR
FBFBBFFRLR
FFFFBFFLRL
FBBBFBBLLR
FBFFFFFRLR
FBBFBBFLRR
BFBFBFFRLR
FFBFFBFLLR
FFFFBBBRLL
FBBBFBBRLL
FFFBFBFLRL
BFBBFFFLLR
BFFBFFBLRR
BFFFBFFRLR
FBBFFBFLLL
FBFBBBBRRL
FBBBBBFRLL
FBFFBBBRLR
FFBFFFBRRL
FFBFFBFLLL
BFBFBBFRLR
BFFFBFFLRL
FFBBBBBRRL
FBBFFBBLRL
FBFFFBBRRR
FBBFBFFLRL
BFFBFBFLRR
FFBBBFFRRR
BFBFFBBRLR
FBFBFBFRRL
FFBFBBBLLL
FBBFFFBLLL
FFFBBFBRRL
FFFFBBBRRL
FBBBFBFLLR
FBBBBBFRRR
FBFBBBBLLL
FFFBFBBLRR
FFBBFBBLLL
FBBFBBFLLL
FBFFFFBRRR
FBBBFFFLRR
FFFBFBBRLR
FBFFFFFRRR
BFBBFBFLLL
BFFFBBFRRR
BFFFBFBLRR
FBFFBFBRLR
BFBFFFBRLR
BFBBBBBLRL
BBFFBFBRRR
FFBFFFFRLL
FFFFFBFLLR
FBBBFBFRRR
BFBFFFBRRR
FBFBFFBLRL
FBFFBFBLLL
FBBFFFBLRL
BFFBFBBRLL
FFFBFFBLRR
BFBBFBFLRR
FBBFBBFRLL
FFBFBFFLLR
FFBBFBFRLR
FBFBFBBLRR
FFFBFBBRRL
FBFBFFFLLR
BFFBBFFLRR
FFBFFBBLRL
FFFFBFBRLL
BFBBBFFRRR
BFBFFFFRRR
FBFBBFBRRL
BFBBFFFLRR
BFBBFFBLRR
BFBFFFFLRR
FBFBFFFLLL
FFFBBBBRRR
FBBBBFFLRL
FBFBFFBLLL
BBFBFFBLRL
FFBFFBBRRL
BBFFFFBRRL
FBFFBBBLRR
FBFBFFFRLL
BFBBBFFLLL
FBBBFFBRRL
BBFFBFFLLR
FBFFFFFRRL
BFFBFFBRLR
BFBFBBFLRR
FFBFFFBLRL
FFBFBBBLLR
FFFBBBBLLR
FFBBFBFRRL
FFBFFFFRLR
FFBFFFBRRR
FBBFFBFLRR
BBFBFFFLRR
FFBFBFBLLL
BFBBFFFRRR
FBBBFFFLLR
FBFFBFFLRR
BBFFFFBLLR
FBFFFBFLRL
FFFBBFBLRR
FBBBBFBLRL
FFFFFFBRRR
BFBBFBFRLR
FFFBFBFRRL
FFBBFFFLRL
FFFFBBBLLL
FBBFBFFRRR
BFFBFBFLLL
BFFFFFFRLL
BFBBBBBRLR
FBBBFBFLRR
BFBBBFFLLR
BFBBBBBRRL
FFBBBFFLLL
BFBFBFFLLR
FBFBFBFRLR
FBBFBBFRRR
BFFBBFFRRR
FFFFFFBRLR
FBBFBFBLRL
FFBFFBFRRR
FFBFFFBLLL
FBBFBBBRLR
BFBFBBBRLR
BBFBFFBLRR
FBFFBFBRRL
FBFBFBBLRL
FFBBBFBRLR
BFBFFBBRRL
FFBBFFBRRL
FBFFFFFRLL
BFBBBBFRLL
BBFFFFBLRR
FBBBFBFRRL
FBFBFFBRLR
FFFFBFBRRR
FBFFBBFLRR
BFFFBFBRLR
BFBBFBFRLL
FBBBFFFRRR
FFBFBBFRRL
FBBBFFFLLL
FBBFBFBLLR
FFFFBFFRRR
FFFFBBFLLL
BFFBFBFRLL
FFBFBFBLLR
BFFBFFFRRR
BBFBFFFLLL
FBFFFFFLLL
FFFBBBBRLL
FFBBFBBLLR
FBFFFFBLLL
BFBBBBFLLR
FFFBBFBRRR
BBFBFBFLLL
BFBBFFFRRL
BFBFFBBLRL
FBFBBFFRRL
FFFBBBBRLR
FBFFFFBLLR
FFFBBBFLLL
BFBBFFBRLR
FFBFBBFLLR
BBFBFFBRLL
FBFBBFBLLR
BFBFFFBLRL
FFFFBBFLRL
BBFFFBFRLL
FBBBFFBRLL
BFFFBFFRRL
BFBFBBFRRL
FBFBFBBRLR
FFFFFBBRLL
BFBFFFBRRL
BFFFFBBRLR
FBFFBBBRLL
FFBFFBBRLR
BFFBFBBRRR
BBFFFBFLRL
FBFFFBFLLR
FBBFFFFRLR
BFFFBFBLRL
FFBFBBFLLL
BFFFFFBLLR
FFBBFBBRRL
FBFBBBBLLR
BFFBBFBRLL
BBFFBBFLLL
FFBFFBBRLL
FFBBBFBLLR
BBFBFBFLRL
BFFFBBBLRL
FBBFBBBLRL
FBBFBFFRRL
BFBFFBBRLL
FFBBBBBLRL
FFBBBBFLLL
BFBBBFBLRR
FFFBFBFRRR
BFBBBBBLLR
FFBBFFBLLL
BFBBBBFLLL
FBBBFBFRLR
FFBFFFFLLR
BBFFBBBRRL
BFFBBFFRLL
BFFBBBBLRL
BFBFBFFRRR
FFBFBBFRLR
BBFFBBFRLR
BFFFBBBLLR
BFBFFBFRRL
FFFFFBFLLL
FBFFBBBRRL
BFBFBBFLLL
BFFFFFBLRL
FBBBFBBLLL
FFBBFFBRRR
FFFBBFFLLR
BFBFFBFLRL
FFBFFFBRLR
FBFFFBFRLL
BFFFFFFLLR
BFFBBBFRRR
FFBFBFFRLR
BBFFBFBRLL
FFFBFBFRLL
BBFFFBFRLR
BFFBFFBLLL
FFBFBBFRRR
BFBFFBFRLL
FBBBBFFRLR
FFBFBFBRLL
BFFBFBBLLR
FBFFBFFRLL
FFBFBBBRRL
FBFBBFBLRR
FBBFFBFRRR
FFBFBFFRRR
BBFFFFFLRL
FBBBFFBLLR
FBFBFBFRLL
BBFFFFFRLR
FBBBBFBRRR
BBFFFFFRRR
FFFBFFFLLR
BFBFBBBLRL
FBFBBBBLRR
BBFFFBFLLR
BFBBFBBLRL
BFFBFBFRLR
BFFBBFBRRL
BFFBFFBRLL
FFBFFFBRLL
FFBBFFFRLL
FBFBFFFLRL
FBBFBBBLLL
BFFBFFFLLL
FBFFFFFLRR
BFBFBBBRLL
FBFFBBBLLL
FFFBBFFRLL
FFBFFFFRRR
FFBBBBFLRL
FFBFFBFRLL
FFBBFFFRRR
BFBBBBBLLL
FFFBBFFLLL
BFBBBFFRLR
FBFFBBBLRL
BFBBFFBLRL
FBBFBFFLLL
FFFBFFFLLL
FBBBFBBRRL
FFFBFBFLRR
BFBBFFBLLR
FFBFBFBRRR
BFBFBBBLLL
FBFBFBBRRL
BFFFBBBRLL
FBFBFFBRLL
FBFFBBFRRL
BFFFBBBRRR
FFFFBFFRLR
BFBBFBFRRR
BFBBBBBRLL
FBBBFBBRLR
FFBFFFBLRR
BBFFFFFLLL
FFBFBFFLRL
BFBFFBFRRR
BBFFBBFRLL
FFBBBFBLLL
BFFFFFBLRR
FBBBBBBLLL
BFFBFFFLLR
FFBFBFFLRR
BFBBBBBLRR
FBBFBFBRLL
BFBBBBFRRR
BBFFFFBLLL
BFFBFFBLLR
FBFBFBBLLR
BFFFFFBRRR
FBBFBFFRLR
FBFFBBFLRL
FBFFBBBLLR
FFBBFFBRLR
FFBFFFFLRL
FBBBFBBRRR
FFBFBBBRLL
BFBFFFBLLR
BFBFFBFLLL
FFFBBFFRRL
FBBFFBBRRR
FFFFBBBLLR
BFBFFFBRLL
BFBFFFFLLL
BFFBFFFRRL
FBBFFBFLLR
FBFFBBBRRR
FFFFBFBRRL
BFFFFBFLLR
FFFBFFFLRR
BFBBFBFRRL
FFFFBFBLLR
FBBFBFBLRR
FFFBBBFRRR
FFFBBBBLRL
FBFFFFBRRL
BFBBFFBRRR
FFBFFFFLRR
FFBBFFFRLR
BFBFFFBLRR
FFBBFBFLLR
FFBBFFFLLL
BFFFBFBRRL
FFBBBFFRLR
FBFBFBFRRR
FFFFFBBLLL
BBFFBBFLLR
FBFBFBFLRR
BBFFFFFRRL
BFBBFBBLRR
FBBBBBFLRR
BFFBBFFLRL
BBFBFFFRRL
FBFFBFFRLR
FBFBFFBLRR
FBBBFBFLRL
FFFBBBBLRR
BBFFFBBRRR
FFBBBBFLRR
BBFFBBBRRR
FBFBFBFLRL
BBFFBBBLRL
BFBBFBBRLR
FBBBFBFLLL
BFFBFBBLRL
BFFFFFFRRR
BFFBBBFLLL
FFBFBBFLRR
FFFBFFBRLL
FBBFFFBLLR
FFBBBFFLRL
BFBFBFBLRL
BFBFFFBLLL
FFBBBFFRRL
BBFFBBBRLR
BFBFFFFLLR
BFFFBBBRRL
BBFFBFBRLR
BFFFBFBLLL
BFFFBFFLLL
BFBFFBFLRR
BFFBBFBRLR
BBFFBBFRRL
BFBBFBBRLL
FFBBBBBRRR
BFBBBFBRRR
FBFFBBFRRR
BBFFBFBLLL
BFFFFBBRRR
FBBFBBBRRL
BFFBBBFLLR
BFBFBFBRRL
FFBBFFFRRL
BFFBBFFLLL
FBBBBFFRRR
BBFFFBFLRR
BBFFFFFLRR
FBFFFBBLLL
FBBBFFFRLR
FBBBFFFLRL
BFFBBBFLRL
FFBFBBBRLR
FFBFFBFLRL
FBFBFBFLLL
FBBBBFFLLR
BFFFFFFLLL
FFFBBBFLRR
FBBBFBBLRL
FBBBBFBRLL
BFBBBFFLRL
BBFFBFFRLL
BBFFFFFLLR
FBBFBFBRRR
FBFBBFFRRR
BFFBBBFRLL
BFFFFBFRLR
FFBFBFBLRL
FFFFBBFRRL
FFFFFFBRRL
FFFBFFBLRL
BFFBBBBRLL
FBFBBFBLRL
BBFFFBBRLL
FBFFBFBRLL
FFBBBBBRLL
FFBFBBFLRL
FFFFFBBRLR
FFBBFBFLLL
FFFFFFBLRR
BBFFFBFRRR
FBBFFFBRLL
FFFFBBBLRL
BFFFFBFLRR
BBFBFBFLLR
BFFFFBFRRL
BFBBFFFLLL
FBFFBFBRRR
BFFFBBFRLL
BFFFFBBLRL
FFFBBBFRRL
FBFFFBFRRR
FFBBBFFRLL
BFBFFBBLLL
BFBFBBBRRL
BFFFFBFLRL
FBBFBBBRRR
FBBFBBFLRL
FBBBFBBLRR
FBBBFFBRRR
BBFFBFBLRR
FFBBBFFLLR
BFBFBFFLLL
FFBBFFBLLR
FBFBBFFRLL
FBBFFBFLRL
FFBFBFBLRR
FFFBBFBLLR
FFBBFFBLRL
BFBBBBBRRR
BFBFBBFRLL
FFBBFFFLLR
FFBBFFBRLL
FFFBBBFRLR
BFFFBFFLRR
BFFBFBBRLR
BBFFBBBLLL
FBFBFFBLLR
FFFBBFFRRR
BBFBFFFLLR
FBBFBFFRLL
FFBBFBBRLL
FBBBFBFRLL
BFBBFBBRRL
BFBFFFFRLL
BFFFBBBLRR
FFBBBBBLRR
BBFFFBBRLR
BFFBBBFRRL
BBFFBFBLRL
BFFBBBBRRL";

            #endregion

            #region Test Data

            var testInput = $@"FBFBBFFRLR";

            #endregion
            var strings = realInput.Split("\r\n");

            var maxId = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                    var a = strings[i].Substring(0, 7).Replace('F', '0').Replace('B', '1');
                    var b = strings[i].Substring(7, 3).Replace('L', '0').Replace('R', '1');;

                    var row = 0;

                    for (int k = 0; k < a.Length; k++)
                    {
                        row =  Convert.ToInt32(a, 2);
                    }

                    var column = 0;
                    
                    for (int k = 0; k < b.Length; k++)
                    {
                        column = Convert.ToInt32(b, 2);
                    }

                    var rowId = row * 8 + column;

                    if (rowId > maxId)
                        maxId = rowId;
            }
            
            Console.ReadLine();
        }

        private static void Task_6_1()
        {
            #region MyRegion

            var input = @$"xav
uavx
xavsi
yavx

efokjptizdcwmqnuh
qgfdvurtnjwpichxk
taqkcunfzpmydiwjsh

mzbg
tmg
rlvge
hgpbzn
cagkijyu

ahynbmqljzpwxokcfrtsgeud
xwzcmdhkrjnupegqlyoaft
fjnurhzoqmgwacxdlypkte
qwrjxahtlnzcfdouepmkgy
ezpqxfcmgrnhylukwajotd

jrxcnyadsgbtpvoze
secpytarvdzjgb
ycsfzgtedarbjvp
tsgejyzcdbvpra
ygtbvzredpacjs

n
n
s
n
n

mgfb
mfg

xfjengy
pubw
isroqb

hcnkeawlbfso
twocmsbefvlp
acwyseblorf
losebfcw

dixstroacjbygqpewvk
mdcpbnfqsgxvaikwujtr

u
uvk

vpuzogn
lmhxvfgkdnspq
jpvzogntyr
ajpngbcivw

bip
itb

uvqldphg
edpgfh

gm
mgfs
mg
mgq
gm

gtkm
wkcgmsvda
gmksap
mkupgt
gekrbimhj

hknejx
wjn
jano
jvwnb
ujnic

vkzmgdb
zbgvd
bzdgv
gbvdz
zdbvg

sedcuh
axyeqbs

ckysjbmawxpedqov
ilqcuxpvajwmfyko

xcv
xhevkc
vfxcy
wcvfx
cjxv

wetaojdqkip
kyedwuprqast
tadubqkflp
yanpslwqdtik
zmgacdpkxq

akdhyogxqf
ktnyzhxoaqfgwd

dbnezgquatrm
ewnqlzdjcgb
hnzdebjgql

aoxjcbpzisfmkewqlngduytv
difaqevcgyukztjwpmbsxonr

grptdzn
pzctgolskr

kvyjetqndhf
yetdvnqkf
svwdpxqgeianfk

tmyreouwn
torwnaeumy
tsewnmzypo
emosthywn
mjtkevnqcbdiwoxy

zstlfpnavdwyicuhb
twlpczyhunivda
ovnuwycptldhzai
pcyhdwtuianlvz

kwvaunqjryxtpz
wflvuzhnxmecokiyjts

kjcqzvhseaf
qgfmhsekjctv

tcpvqdrnghflmjoxawe
mdplxfqnovejsgazcrh
qxkhmvbpdoegnfjrlac

ixzcphskly
gsxioyzcahkl

stjxfn
cpdegihznsoyl
vrujnsk
wnsqmb
najbs

pxatigolezv
xkbvuitegwmo
gvijtmysxoe
svnxeqjogtik
soxevgqcit

otzmkhlquxwrani
eqdjfgmaor

exz
qze
ze
ze

xwzapvtqrgecjisfunkhd
qefspnwtkijacuhdgrz
zqjkasgnferutdwhcbpi
rwapenikhdjcsqfzgubt

fmjeqdaivksonr
pfeljvbqdsormxh
uywvtceosm

zhlao
he
h

qnyhtezxjdvpfkcsio
nvchtzepkqjoisdyfx
vifhcnxstzjpedoykq
qsivneohjzpbdcymlgxfkt
sxvkpohctnjfyqezid

ndzhflc
zfdcnh
fchznd

nrvde
ramndvu

tskgvzqmun
szckqgbvmnw
zvmsnrygaq
vcqmstinzg
jlospfehmzvndxgq

btlfvysaqerchkiux
tlyxhkrvbqufsecai
vfturxsbayicheqlk
sruhcbeqktixvfayl

vam
mv
vm
vm
vm

k
k
k
k
k

ysmikquxzc
yetmlxqsziu

ornk
orkn
rkno
koirn
onyrk

qcajzosf
sofdacj
ajoscf
djfscaeo
fosejac

rkqghbxjdol
uqbdhjkm
jhbd
cbtvadiehj
hfdbrj

nsklymutzivw
mounvbpwdg

sdpgvajmexuyqhcriok
vjksamihwpdrcxqguy
xjsevuydcamkihoqgpr
mjtcnqpgdhvuakfrbxyi

hpoyrxfmcjld
cxlpodryfmjh
jhplfcrydxmo

kembuivdhf
ipefszdh
enclshdbfk
dhreytjwxqgfao

lb
lkr

smtknclagp
pcktnslgam

bfsc
ynbf
hbxklwfep

ye
haybes
ey
eyw

ta
tan
jtap
tah
lcat

ikdqblgs
mtwlvhnbkjsdic
plzskbdi

rctauyzbdklxvpmnwqjfe
plhzdsnbmxqarwjktyfuice

ba
ab
ab
bar
ab

i
i
i
v

ursqy
qrwusy
yrsuq
qrsyu
qursy

cdgrouis
ocrigs

vjwaiph
ypva

yhuqbinztxg
kuqxeogthpid
gtmhiquxlw
gxutsafqbih

wmg
wz

gkpmdtwhnxzaoysjcevuir
hoxmkyqdcwlnvgperszi

oqagy
glxvkq
sdzbreguiwjfm

nabml
pfnyvatk

pu
pu

hbivy
byuv
tueovyb

ozqv
qzon

xjunwvbzdkqy
chfosmgre

dyn
ejxy
xydq
yx
iyp

hskfyqgtbzrvu
yvqhtgbuifrskz
hzjqfuyrbvstgk
zvkhtsfgryqbu

ons
osne
nous
suno

zymjefdwxih
dwxzyfjmieh

ib
bia

ocagmvj
jvcagm
gamcjv
vjcamg

inhlewtdbkxmpaqryg
wnkpxrhlmigtaydbqe
oihnlytpwaxrbqekdmg
mqabydwgterlphnkxi

bjedsywlgnxmpotz
pxejsongtkumzbwld
lpogxznbtwmsjed
tzpuonmjxlwbesgd

wqfsmektu
wmftqs
sqmtwf
tqmscfw
tqwmsf

snkpjbefqwhyriz
ikwrlqymjczfbevntps
qhebojfnzrkwapmsi
begirdpqnjkwuzsf
iqtbhfzpenwkrjs

y
y

gsf
gcsh
ajqgs

ulqbokwrjdcgpthniyxfzmeav
rjbumtoxecngkdvazsfilw

fwsrhjk
hjrfwks
kfjrhsw
jrhkfsw

qktgsvplh
hgol
hgly

qftenaodxkwz
bwtxaqviof

ugzpmhefkj
kgemzusfpjhd
ekfjlhpmguz
kxuepjgonfyhzq
kuzgitlhfjep

jywhzcrqa
otznge
mbuvfsk

iwhekorjgqtsdb
kjgswlbqherodti
okirgdnejtxwbqhs
ezobksgqrajhwdti

rdcoaubxhkitwsvpzygflmqnj
tcnfguzdybojqvwishrlapmkx
smjnpglbkzuafqhtdoxwiycrv
spgnmzlyurchxvwbojfqakidt
kzdtmbslqyvxcrwnauhoijgfp

kvwm
mwvk
kwvm
kvwm

hto
rhg
h
tvhi
vhfk

woxhpvfdlnezi
wemd
cqwkde
sedwuq
wcadtgrbe

moecds
wscmbnoed
sdycmeo

amnqlcytodvreiwkzgfxs
vfwmayqsghdcjztxeornkuil
xgaifqzdvowmknlysrtce
iynsxqwmafdvtklzregoc

ksvejm
eskmvj
ksmjve
vhskemj
ekmsvj

ebfkazr
dgqtkjmw
clykap
zukinrbh

oznuhklqijpmsxfcaryb
hyikolbjusmxqcfnzarp
uzxcbwqshkyamrielnopf

zlpsua
wlzdspu
luzsp

h
hkr
h
lhc
h

zfugqrjipavboys
aurvpzfeosigjqy
srnqiejtoyupgvadfzb
oqryvigjzsuafp
qgowivrzajsupfy

mrotnsaivyxbwp
iapmtxsgbyodwr
woaxsyjicpbtrfm

rdlakocwumetfpjs
cshjuyxwgatvz

wbxauycv
xbwgaove
axwnovb
fwyxmvab
xtiqwbsazvjpl

o
p
p
p
p

ombjurgkvceny
ilxtpwaz

gzjpkewnfylari
nlifyawpzgkjm

ymhesgwkxczrtbjnu
cywuetkbhnsxjrzgm
uwybxgsjnhremztkc

pcsxyiuvfnjbtkqwhlgzr
ixqnskyfwrtlgchbvjpzu
cvuqazjkhbxtlyrnwgifs

ce
ec
cge
ecg
yeh

itfhrlsvgden
svhekgidlrnf
nirlehsgfdv
sginfeldrhv
irsvdlfhegn

w
y

jqwevpgkzhdar
pazkvjqdrwh
urzhvwkpaqd

lsmqgjkb
glmksbjq
qsklgbjxm

iouyxrvbqjcemzlapk
ovlkizemjyarbcupx
zluckepmbrxivajyo
zijoveubxmlpykrcad

tjaruhsdgype
apmetysfkivjblqd

ztxyvufeh
dmcaqrhfgs

qfvujnhtaom
uvqanhfo

dxwvtmlsjqurepbgni
bueiqjanvlpwr
zlryojfupiqvec

dopjewaytmg
amreytdslkgpw
peymdawotxg
uqyahptdxzgecwm
vbohdafmpiwytge

zdkalgubsqw
dsazbkgluw
dsuzgwlbak

fibeyzxkmch
fveymznaik
vtyafiemkz
erlfizymuk

uti
u
gu
u
u

khqjtmswgl
pxnsqzgv

uhkeosrgytcpbvmanqdlwjfz
singwfcorvzadktblmupejqy
lezdusrpwbnfmkvjcxyogatq

nqlmhgrp
e
sw

hrmxwjzg
wzrtpmah
mrewhx
ywkbrnhmci
rhomuvw

cfpsboei
wtifcoybpx
iofcpb
cbpoisf
pcoibf

x
tx
x
xf

etvc
coap

gsbmanzopklyw
zorpislaqbnmywg
awbgczsdxlumypnoh
wtmkgobyaslnzjp
pmjlbsonkfwgtzay

upqwyiagtonfvrsk
dpkvuwoqfaiygsnmtxr
unorfgkpiyasqctzwvh
kbwpyrniohgufqsvat
pfqgsyuhnovktirwja

egkzlwjd
szermjwkl
kaelwjzoq

efmclagdkwhqxrosntzvib
mdhlqfabcrwsgxonizvkt
dhbqlnftivxwapoczskrgm

oxsedbl
zsblx
lrfax

tv
vta
vat
gpmosjtv

ltgeu
tudo
dtuoa
tud

ycsajei
sghikbpmr

bjfohqiwcpd
lzeysr

ghcenrzqksifd
ckwsgdnerfziq
iebsrncqmfk

idbjyxctlgpwas
wgiypblsacjuxd

ivnkjswb
bk
krb
kblc

hbmocfrual
urlfbmocha

mtvwqhag
wtxdcuen

bmdary
wjma
pexakfgu
bhijav
vlmcia

jeaposhgqcblxitkrzyn
aordjqiglcnpvekthsbzy
jhtrkqynszelcoiabpg
jkftnvbgyqploaicsehzr

q
qt
v
t
z

qidvuo
uohvqibd
udivqo
oivduq
vidqou

xjlbhrsnpat
qsavnktzbuldprxh
gxswnpftrehlymi
sahprlxnctz

axqni
aciqnx
xqian
axnrqi
qxnia

tbuicahr
banvchurti
grtbwaihclu

jylfirgmsx
lgfmxjri
xgmklqtfrwj
gxmlsfjr

ayunwcgj
gmcyn
gdtvfioexhys
bgyl
ngqyc

neyazrtkxjhbg
yxjzqknb

diljtqg
qwsnyuabx
qsfhuzv

qzpj
zjqp
qpgzthj
qfzlpjcydxsn

sbkrcjleytuidw
wcbtiljyedmsugk
zubetwdyikjcsl
lwbdieutjkcys

c
c
c
c
t

pdglkmircznxjshwytq
ikqrzgyxtdnjswmphcl
pgihtyjczwdlsqrkxnm

ysj
ysjf
fjsy
sjpy

c
ca
c

fjaounzyrck
uqzfontkrajy
auoyjknrzf

adgezcjtmlwbnkxsp
zlkjswmgabtcenpxd
wedpgjnmlzibkasxct
bkcfsemlqzujnxtgwadp

xrdzvqcyawst
vztcaqyr

p
pw
hpf

syzmig
lqpmnh

qwkysudhal
myk
tykc
ky
ykm

napugxj
pjnuxga
jxpaung
xgjnapu
jnpxaug

xcwklzsdouvejph
wvecjukzhpsnl
uzksblpwigjchv
szkwpncyudlvhfj

mazvxenotrbjpsg
xabenjzrgtmocpsv

amkxogyl
lkmyxgoa
yagkoxlm
awykgxlmo
gxayomkl

euqjn
eijrqnw
qnje
enjq
qejn

qmicpr
pc

mhfelurtibxzg
prcigefthzmbulx
behzitgmxflru
uxgrmzibtelhf
rzfluixbtmegh

trwq
t
zt

yjbcohw
jueqzodyk

tyroqsxepnbfckhuazjdwvmgli
byjcgxmurontvhspekwqildz
svtmwnbighlpxeyokjurzqcd
blprtoqjwnmyuxvdzkeisgch

mrwtb
trmbw
wtmrb
rmtewb
twmbr

jlwri
drwibj
tiwre

cz
cz
z
wusz
zeg

gxqrucimko
zhpqfvbinsy
iqlwdgtje

wyzjqgdihbxar
lwcivxtmaojgbzhp
xzuwgjrabkhfid
ihsaezxgqnybjw

jtair
kfsv
ghze

u
uj
u
u
u

epbvkzsoyqlrifatwch
tfzwlivkhsrbceoqpay
wzcqpotkrhfliavbyes
wvgeufcbopsqymritkalhz

vkaldbmyewi
rcxvlibuedgamy
lysiabjdkvme

nwhqcojkpgvfatderylibxz
hgnoiclkaebtpdfjvmzywx

gafbqnxstirzvoheydmlpwj
hqrukwtozblfyasdxvmnpgei

abpzed
dapzb
wcbdnzapj

uho
nmp

yofngr
amn
n
n
mn

zguhotqnvkepfyabr
okwtbzaqfyen
konyqtbzefa

inbtkepjylqdfxczmoauw
mzolcwaxfnbditkejpuqy
zjyoifdkmcaupenbtwxlq

yuzri
rubyi
yiur

otdbszvjhecrkiypn
ydmovicrbzfkeshqng

efc
e

orbzu
iszurwb
becjrkzup
irlznub
xbtragfdyqz

fpj
pfrd
fpr
fpwc

rklcfn
nflck

li
sli
ik
i
isv

awuhgmb
jznsiqycker

y
y
vmpdu
ok

jeionpfgkvxdmrzlyc
diblznsykpuxwqfm

mlykav
vmka
aqvrkdm
vkmiaz
rmkdvaq

uyljahgbxsvczpkdq
rowf
ntemi

xjhaitwlozdpcbv
dvnzjxblpcahoiwt
xbwdolatjhvczip

spohauibt
ipsatqnozlxvub

vuzf
fchz
zf

almqujgzovhyfkbwtindre
zvskmgitqyweoldjufranbh
jrkeqfanmvoiwblzdthguy

y
y
y
y
y

fsqxhnbtcdy
bhkqnvxdws
qsdnxihbm

c
cvip
wcqp
xrkjc

cbsfeonkqthadzimpwyg
wkybvhdsnaztcgefpqom
dipbljsqxfecakmtyoghnwz

ocxiztfw
djhaepyqu

pbyzfvq
rpqzvf

p
p
p
r

fgj
mghx
cguivrnzdw
xhmqlgf

lypf
fpyl
npylwaf
leupfy

rxyzatoj
xvfin
bxlfk
ucbqx
lx

rkixw
fk
mk
kmybf
vkqg

macdvsjophnzixyukwglqef
uhkdzsyecoixjpgqvanlfwtm
nszgjudxpfchoameiwrqylkv
hgkswmlvjyufeipaxnoczdq

hkvtprgxom
mxitpvkgdrho
mphkortnigv
kvtprlhmogd
kmverqtohgpwj

krsazmfbdtxyuijh
iebqjdruma
dimbrjua
imjurdab
ajrbuicdnvm

jzroas
vwo
om
kmvo
fo

vckphlabort
ktprcvabohl
tabrkohlcvp

lb
j
xi
p
i

ibxswpzlgak
pablwzkxs
kzablwpxs
xapzsbwkl

texidwzkyjcapn
djptyzcernia
narcjoiteqzdp
cetbjpzavigmnd

thxzfeocaqpkd
rvgoyxzlk
zkox
kxuzngo

dqsofevyrijctbxzwkghn
kjwvnobzergsihtdycqxf
robqyvzihwjsxcdfektgn
octvjeshdiwbyfngzqxkr

f
udzlmcrjehivqpx
agn
owb

vokdu
dck
knd
kd

txqlzrv
tvxlqzr
vxaqzrlt
tcxrzvql
qtzvxrl

flnc
lsk

agqspncoikwytuvre
muyijzoltcepsaxkdvhbgf

gmlyx
gakyvsl
cdthyjrioubq
myl
awezy

dfzvhkblgnj
kvzjdfgbnlh
hdknbjzfvlg
jkgvnzldfbh
jzkhfvgbnld

jvdkxqsrio
rpuqvkncfgzit

oqzmkjb
glehuw

stweunormcqdyivabxk
plgihfuzjbr

fiakobrucnqyjtxsvmw
utcfankbwvozqjxy
vqknowtacjbxyfgu
qboaxvykfcjtuwen

lqxfvjncarmowzst
sgpnhq
spnyueq
kqns

plis
i

alqp
dpml
ycntviwgf
zkeau
pkxo

cahvspxi

dgyk
kydg
gycdk
ygkd

ygxdtqsiralczwmfoke
fqeoltimdykzgwxrcas
mlrzsgafxqcidkweyot

ibpuxwfrnjygadl
ucbjmfziyklnrdxw
wbqrxjdihesvyunfl
zfubxtylwndjrpimo

ahdf
aq
awjyc
as
nah

klygiqmwhzubproas
dhetbmfiazsqrwclvugpk
ugnkxpmqirhswazlb

n
otzi
q
o
dkfx

gwoidjb
sqownkvt
oywgjxa
iwoeh

kcsfhg
gfksc
gcksf
pcgsfdk
hsckgf

lzgtrfpsxwqhi
yqzovtixp

mqyhlxgfnbtcvwejpsrdouzik
simkqtcevpohxdygbjlzrnfuw
dprugmhqkcwveixoyjbstznfl

m
m

akmrpwutnb
lnamrphkwtf
rpumnazwkft
kwrtmpvan
mjakwnsxrpt

kgstyrbauzjiqfmdl
rlpubyfadxmtijgswzcqk
bzsfnumiadjykeltgrq
qfavbdhujrglyzstkmi

zvxca
xazcv
avcxz
twxcavzk
vxzoca

kyjbqhd
yqg
mleagqy
qnlgy
rvqya

rkbfpejgaqunlhy
hogsunxedrlkbaj
ktzjmaugrnhblie
rbkgnajlehu
qelbwhuragjnk

pkbrlq
fhlvcetzujqo

dbpnjmfgzuaky
qrmnapvjswgyzfecl

oubx
uxb

k
t
ce

qo
oq

nrdoliybfmk
xbfonlytdi
odbyanilf
zdyinxfbrlmv
bnfgwdiyls

ptqr
yhpr
oifcxpumwares
rhbp
vrp

edmfbockpuzjl
mejpzldckfoub
bulkamoepdzjfc
wjblknodpmczufe
plbzukcxvdhefjmgo

sbfvdziayohutkxmcepnjgrwlq
slqbthaugnxcfejkymrpvdzwio

ovnuybcjzw
cubyavn

jlpyfemohwb
ympjolewhfb
hpjymbwolef
hmfewypjlbo
yjwlomhpfbe

yudoticgpmswxheb
imctpdhksgwavxbefuy
ytmhucixswdegkbp

femhgtsc
hgetcp
gct
schmgt
acogbzt

jdfzyhgnks
kfmgndbypsjz

qxkrsvfih
xvirkqfh
kxirvfqh
phvuixfqrmt

jwq
ovwjq
azpjnys
hjw
j

mekjycug
okyicj
jevq
dzsharjxltp

ageqsriyfoupknldjz
bqkjhmi

arqoszdiyemtlpbcukxhg
tskxzcqmelhorypiua
ikcwsfalhzymorqxpetnu

o
wj
o
o

hoqrjzemyfidak
hdofikzyrjqaem
amyjorkehdizqf
qyajdekzmfohir

rfgtpasbvquzykj
kwdcasjtyvzfuqegpib
tpangskbuorqyjfvz
qubhzfvakospgtyj
tjgvuayzfprksbq

xvsetimqaglzhubopjnkrw
vretjpaqgzidoulbmxhknsw
kxzwjmscaeulgqnpovihbrt
riwnepagmhktvusxqljobz
tugmqkbasnzhjivrlpwoxe

yawojch
aoyhjwc
wjcyoah
ocawyhj

atfkezomu
bwghcxijm
lmydqzvnpr

nfajymk
yakjmfo
skayfjm
ayjvkmfti

zbcgaxyjd
emltdhkwsug
dqgfnue
qgnvd

ibecm
ecmbtfislo
cxympeuib
iacrepxbm
ckibme

ednxkzblgoqwrys
naklxbrzsodqegwjyf

mabnelwrzy
keandpqxbmlo
gviuhjstf

xlzoysmpdgfcabiqetr
mplwsgnxcadzfhukvrqjeybo

l
l
l
p
l

zyjuwao
odfv
skqoc
omvrcqbh

fgpcjvmbxuiwtehnd
pcfsgtxbnkuihadm
cdgtfhbmxpuni

e
ea
p

ild
ld
ld
ld
lhd

hwelutk
wshulk

milbjvxorn
lbivoxrnjm
mjxivlrobn
ilxmovnjrb

inhcdkotgs
syndfwkghteico
gkhdiczostn

jgpmfyqskc
kgfyqpsmcj
pyfckjgmqs
gskpcqyjfm
pyqsjmcfgk

opbqxluhyvskn
xonskvbpuqhyl
vnijlhyqpxukgosdb

dzglxpfnt
nfptl
qynmuvrcp
zdnpk

ligcsyexbdoqt
educotylzjb
zuyockfnbhtedml
owlyuabectdf
ycdrabolte

hw
qr

utqdisoacyr
jgnbvzwmhekfxpl

s
i
i

ovbhcfp
oauvcpte
qowxkpnyjlvdismc
zvctogpfa

qtsmhpwz
qchasetf

ysmvb
byvsm

yjkvnlqcpgasibtex
ycjgqedpvnx
nuygpfzhvejqdxc
qwyjenxfvpzmcgu

tlribvnydjfex
rmpjdqsbzgcxv

hn
uhn
nh
hn
hnz

yvzrqpbel
blejaozvmypr
ebrlvfyzwp
brzpyelfv
zwbpyervlf

rtgnjiawecpmu
ejcnpgtawuirm

qhuybzmv
pnwzceb

cuijneskratyqgwxmodzhpl
wtqshpyzrcmokixgjbenf

wrthvasmxk
hvktmsarx

s
sp

td
rvjitl
tdpk
t

mgdaqpzefbxh
xfbmeadgzqcn
eragqjmlofxysdt

cvzxwpf
pxwuef
lxswpeft
wxpf

eqckjbluvodhtg
cvgujlhekoidtqb
bhdoltuvgkqjce
vhgjcektdbuloq
jdogqblchetukv

hmgwcszjqpyxil
wzplksghxcmyji
gkiczwmlyjxsh
jsgxcmzhlyviw
ujihlsyxgmdzcw

ofrubwjqkxpzaitevscmgyln
bigsuetvkorzqpajxwfldncm

qink
inrkq
knqi

jvnayiodwg
dos
tmhzeqdpo
hods
bohdklfu

i
i
i

ndwutoamyzbrpqsveg
zbdswnrevapmgty
zdtpnymegawsvrb

obwzklcynjgme
zlkeyfcgwmjn
icjzemnypwklgo
munwqycgzkelj
kcnzjsiylwpxgem

nbaeiqstvdwmhjukx
njxvowhqdfabieskmuzt
wbnsutjqdhgevkmixa
ycjswbkaqmvixlhutned

okcwymdgvfhlxzt
odygvtkmlwfxzch
wcmgjhdflxotzkyv
kaxyfglvwmodzcht
dxcafvltwokmyzgh

rejdmivax
xdamjver
ejvdxmar
rjmedxva
edrvajmx

lkqgnc
lnckg
lkgcsn
wklnhcg
lcgkn

upnosleiz
pnlszwe
esjpdnlrm
hnletqakgpsb

fb
f
f
frz

d
d
d
d
d

lyqavutgbwiehjrc
qcragbvihujlowtpy
tzyjhawliuvbqdrmgc
rglvzjtuidbcywqamh

edolzs
luoeshd

v
v
vg
v
v

scwuqekdbmarfiy
nzoxvptg

ycpvjeubrazgiodxtwn
cptzsxjmklyvdeaonbqiwr

kbmqslrvnyzpj
slxfnbqpjy
jsypwbnlq

xv
oxv
xv
vx

ulzdr
zoshulr
xduzr
zrqju
tzurvebgc

vp
v

n
fn
n
n

bmpfnxzsajwvyhqldrecout
rvnpsoxzlcmeufthkjayq
hozncuervmgqpyfatjxls
ovrxesptqajlzycfnmhu

lfjc
fc
fc
fc

jdhrx
jranxydbgt

y
y
y
y
y

tpfydje
ejpdfy
jyepdf
epjdyf

b
gphf
e
uvkc
jza

glyxuj
gjulxh

ubmeofqsxdangrchivy
yhcueqvgfasordxmb

vbtex
ubenvxzkt
txbvae

yoxb
byoex
obxky

vxhroygampneuzslckibfqdj
jqfcvnaizeluhkmrdxpy
eidxrkcnvjzhpqymaulf

dtlpjkfar
sjtprafdyel
afpgjtvlr

z
b

rwutpgkyanm
nwatgkmpuyr

jb
bj
jb
bj
jb

yvcbs
csvybh
bsvycu
csjrinybgpv
yhsvbocw

tapdxjkbuhn
uqoaigmtphcfv

gbrf
bgrf
grfb
brfg
rfbg

lhj
r

nsuvr
rntus
rnmdcsu
nusr
usnvr

mglncfrspjxqdheatkby
awokdbmlvurnzjecqsyxpth

dkphrovicb
oihkdcrvpb
kcdvhbipor
ichrbdpvok
prckhibvod

obaxmnut
otabun
haobdtun
pvfnztekujcbqyoa
tibmhoagun

mvhtqgsxc
ztljokabwni
tdyuefmqrp

gdx
jnxk
x

bwfpeojrtnqmszhya
jfduwroxmenzhky
mhfrjediyznwclokv
hfjirnwymekgzo

bzcpqi
ipcqbh
ciqpb

vbnegldq
ebgvq
equxgbv

pmcjwzqsrgye
svhujyprdftb
pjsnaryo
onsrpjy

dfqbynoxcgljpuhaesmvt
dxhecqampgnyultfjosvb
cifqxleudmvjhgaspybotn
snqvtgaphyfloxeucbdjm
ayetuxbogqcmfnsjvhpld

woqjbvaesrh
rmjaeswobqv
rqeswbjoav
owebqrvajs

fsgejt
jskg

obzeufrsykvjdqg
jqaiozpwrmbsdxkf
sjqdzfktbrlho

awqldosnzykc
dolsawqncz
wodsqznacl

ohtxrakybsecjnqviwduz
mwodbqsxihrajpcztygluknfve

m
mv
amq
m

ahoubdnlywcigjt
cynbhdivwtoglaju

bpgewx
zxpubsdwq

adhjekz
tzjkde
ewkvzjd
tvefjzdk
ejdkz

uetkosjndqgxcyvm
mclnrsaxjytqvdpg

kbhed
dix
afdt
d

xhd
hgrd

rbyavgzjflhdinqesk
snkvihbalfryjzeq
zhaivknreqfjsbly
brkljfziyensvaqh

bokdlygwhafrc
xwuronlpakqi

pnwsxh
pnrwsxh

yhrqpsbjv
dav
iwuoxlgfc

hwge
ihwejbsv
zneltwyrhfkaom
ewxjvh

oxnscztqjyafr
hyxnkjvwrufcm
pmcgrnulkfjvxy
berfkxyucijn
wencyxrfhlj

kilhnpjvdofbatcz
rhgvxiwmncfez
vizhucnqfe
cnhzivfu

umxzfpvkb
vpkxumbzf
xzkvmfbpu
uxkfzvmpb
pfxvbumzk

vmsdxahqipznu
fupiasyvlnxjzdrhq
unhagxpkvdsqzie

vdwyb
vyudwb
cdywvu
ydvw
vwjdayh

d
d
d

qlfcbhrvw
fzrbyuc

jcsonk
uckosn
kcsno

sawivom
ioas
aois

weluyo
qhcprdvg
sbkwuy
uzynje
najxiue

xbrfmeznhowj
tbycldqagk
uivcbs

uzgpwofxcaqidhntlmb
oidfhxgbnluzwmcptq
tquhizxngoacdwfpml
ldztycveqghipmxsnfowuj

n
qn

fqu
df

cxpvzgfyijsaoltueqkm
ajuxlvozygsfqpteicmk
ozeafkvtlqipjugyxsmc

z
c
z
r
z

jsapzgufkmwvdibqt
aerhpisyudxgmvwbjo
pvnudbctjgfwialms

auylqgmpcfbkihesz
zislkfqgapebch
fleshzgkqbaipc
hpnszqkiatefclbwg
esxlhdzvbfwkpagqci

j
x
x

vcypdnobl
kfabxw
wjqbig
ibzm
kb

hkodlmsgqbzjevcfayi
vfyticqwblkjsuagdpozme
ifdqbksjrxlegomhnczvya

bktgaefp
rexytwau

xwasezkctrov
pcsxbrzhdtw

gzkcdewab
lmd
xyftvqsidhur

kbvzwsdcn
pkbszvw

jsvouxke
qgzi
adrbyz

zvqpbkanyjwgtueflcdrx
cpyqrwgtjafuklzxndebv
wzdgljoaycekvbptuqxnfir
djrguhfbptyxkzceavnlwq

nhqgxmdsl
vtzpkmqdfl
uqomrjelw
zflbvqm
alxmq

smlxpqfh
tkszqhlvm
qjomlvks
qwduyrbsnlim

wpkcvmxuityzqgjdeofb
fvkyxbjdumoptiqwgecz
pbdvuetqczokmxfgywij
zifybkeudwvqgxjmcpot

porctbafwqzedgysxljkhv
jxbdhgqkftnyalsopzvwce
kozvgtxejlcpdhqsyfawb

obduynsxf
dysbxonuf
fbsoduxny
ubycdxnofs
bfysonxud

his
vfxa
xa
fax

yolm
bo

jotsmh
xfqhsbvrolc
hsgdaoz
jotyhsu
szoh

dz
dz
dz
zd
zdk

idykem
asftdpu

fbvmunwkreldcy
blaqkxzvyim
ilbvmxjkysq
laiymvoqhbgk
vpklbmyg

jvsmlog
jgwvmsplo

risldpqb
lbsiprxo
bsiprkl

nzcybwkpah
yhwcpkzna
wzhcnpayk

ixfbamn
inb
ubinke
ncbkei

elchnpjkxwtqig
nljgiceqahbx
lcugbexhqjin
idxjhmeqclgfnv
fqlhcexigndj

vmgcneztlbs
qeblzmvcngst
ngbclszmvet

ckn
c
c
c
c

yezpv
wyvlez

hfdtkslevcwnoxzi
tsfekmdjvclihzwno
etsiwvnzlkfdhoc
ckfotsdnzivhwle

e
y

cdbn
bcnd

hbupimtkawejgvfzcnoysx
zfnkwbpvchoxietmujsyg
jmehbtwivfznkupxcsgroy
gomuvnyjhwekscizbtxpf
hspzxkncvfitwjguymebo

qjw
j
rosg
jt
qjxe

s
js
s
s

sudlgxvitacpyfhkr
isuvgfkrchadnj
gvqfzrmdihucsak
qgrodskhauficv

rqefisluvyg
nyjotwizfk
iayf
yifd
ftyij

alxbdhwiscq
qgcjrwezay
ahwitmqdcu

d
d
yxl
d

zwfdsuqc
dzcw
cszudw
hzdlwb

axv
vx
vx
xv

nrw
blzfvgh

pe
elqmzvgfk
e

ygfk
xdjnublae
r

jvn
nvj
jvn
vjn

mblaqhitwdv
bljivaqxthdw

d
dc
d
d
d

e
d

vjsrl
jrlvqseb
vlsrj
lvrsj

cjfta
ajfct
tjcaf
fjbhatc

dqbfeprkzgvt
tpbfkdrqge
rwaqfedxkpbgt

owbmusnzvgpf
orgvlwkyxp
tvpwohg
wtgqcovp
gpavywoie

gczomkqlvdbn
aolduzmgbqvyec

tynrkjlgsq
qsnlytrkjg
yntgklrsqj
tygrlsnkqmj

pyfrutmwb
ubwnsrfy
yfwrspb
ydvborwf

qlsmcbh
hqlmcsgb

cowjnufayrix
rqaynwxfcoj
xogamefhkdjyrvwcnt
afrznwocyjx
cuirsyxfwloajn

htosau
bvkdcr

ewyzhgipl
lwezhbingydpk
hpzwmijeygl
ieythwpglzm

ozjphrbglsi
rguphzjoyil

b
o
ru

ritlagqevs
itslgaw
gvjsalitr
uixaolkghst

pnjoxwlurzkytdcb
jucwnytzoxbrpldk
lxpboczwtduykjrn
pyzkdnxoljvurwbct
rzupcbnxkwoytljd

snpvyotqzxubard
qorubpavdnxytzs
txpvazrqubnydos
vaotxpszyurbgnqd
pzxurabtqsvnoyd

wcybutsgnvxlpdjrmeko
ursvnedtgjbylckqwoxm

otac
cot
otc
toc

np
ndtfblp

uvaeirsy
vryjispm
smuiry
fzdbyqsrtig
rwkmycveis

jhutgyv
juyhtg
ytuhjg
hutgyj
tuhjyg

zxwyodcm
dwzyomc
wmdoczy
wxymojzdc
ylowdcmvbgz

tjefad
yokb

akbwzocshvu
kchubzawyvos
zbwukohvqasc
hzkbucowsav
zykvhoauwbsc

qsy
jq
pq

bnkryxpdvswjagzhfqtil
kgfawvzjinumhldqpytxrb

yfdr
yfrd
royfd
dryf

wsvptxyhcqfa
fysovtqwxchpa
vahfqtpsywxc
wfqaptcsvhyx

wezkdnqhgufvarycxijlobs
rzoicqxglbfhenksjwv
gwikzclbvrxsnjfoheq
hwexrfocgnjvqbzklsi

dm
yk

xyqbn
cxypns
hkgylf

mhqunico
mchio
hciwosm";

            #endregion

            var blocks = input.Split("\r\n\r\n");
            List<int> sumInBlocks = new List<int>();

            var sum_string = 0;
            foreach (var block in blocks)
            {
                HashSet<string> uniq = new HashSet<string>();
                var string_in_blocks = block.Split("\r\n");
                var contains_str = string.Join(string.Empty, string_in_blocks.SelectMany(x => x.ToString()));
                var temp = contains_str.Select(x => uniq.Add(x.ToString())).ToList();
                sum_string += uniq.Count;
            }

            Console.WriteLine(sum_string);
            Console.ReadLine();
        }
        
        private static void Task_6_2()
        {
            #region MyRegion

            var input = @$"xav
uavx
xavsi
yavx

efokjptizdcwmqnuh
qgfdvurtnjwpichxk
taqkcunfzpmydiwjsh

mzbg
tmg
rlvge
hgpbzn
cagkijyu

ahynbmqljzpwxokcfrtsgeud
xwzcmdhkrjnupegqlyoaft
fjnurhzoqmgwacxdlypkte
qwrjxahtlnzcfdouepmkgy
ezpqxfcmgrnhylukwajotd

jrxcnyadsgbtpvoze
secpytarvdzjgb
ycsfzgtedarbjvp
tsgejyzcdbvpra
ygtbvzredpacjs

n
n
s
n
n

mgfb
mfg

xfjengy
pubw
isroqb

hcnkeawlbfso
twocmsbefvlp
acwyseblorf
losebfcw

dixstroacjbygqpewvk
mdcpbnfqsgxvaikwujtr

u
uvk

vpuzogn
lmhxvfgkdnspq
jpvzogntyr
ajpngbcivw

bip
itb

uvqldphg
edpgfh

gm
mgfs
mg
mgq
gm

gtkm
wkcgmsvda
gmksap
mkupgt
gekrbimhj

hknejx
wjn
jano
jvwnb
ujnic

vkzmgdb
zbgvd
bzdgv
gbvdz
zdbvg

sedcuh
axyeqbs

ckysjbmawxpedqov
ilqcuxpvajwmfyko

xcv
xhevkc
vfxcy
wcvfx
cjxv

wetaojdqkip
kyedwuprqast
tadubqkflp
yanpslwqdtik
zmgacdpkxq

akdhyogxqf
ktnyzhxoaqfgwd

dbnezgquatrm
ewnqlzdjcgb
hnzdebjgql

aoxjcbpzisfmkewqlngduytv
difaqevcgyukztjwpmbsxonr

grptdzn
pzctgolskr

kvyjetqndhf
yetdvnqkf
svwdpxqgeianfk

tmyreouwn
torwnaeumy
tsewnmzypo
emosthywn
mjtkevnqcbdiwoxy

zstlfpnavdwyicuhb
twlpczyhunivda
ovnuwycptldhzai
pcyhdwtuianlvz

kwvaunqjryxtpz
wflvuzhnxmecokiyjts

kjcqzvhseaf
qgfmhsekjctv

tcpvqdrnghflmjoxawe
mdplxfqnovejsgazcrh
qxkhmvbpdoegnfjrlac

ixzcphskly
gsxioyzcahkl

stjxfn
cpdegihznsoyl
vrujnsk
wnsqmb
najbs

pxatigolezv
xkbvuitegwmo
gvijtmysxoe
svnxeqjogtik
soxevgqcit

otzmkhlquxwrani
eqdjfgmaor

exz
qze
ze
ze

xwzapvtqrgecjisfunkhd
qefspnwtkijacuhdgrz
zqjkasgnferutdwhcbpi
rwapenikhdjcsqfzgubt

fmjeqdaivksonr
pfeljvbqdsormxh
uywvtceosm

zhlao
he
h

qnyhtezxjdvpfkcsio
nvchtzepkqjoisdyfx
vifhcnxstzjpedoykq
qsivneohjzpbdcymlgxfkt
sxvkpohctnjfyqezid

ndzhflc
zfdcnh
fchznd

nrvde
ramndvu

tskgvzqmun
szckqgbvmnw
zvmsnrygaq
vcqmstinzg
jlospfehmzvndxgq

btlfvysaqerchkiux
tlyxhkrvbqufsecai
vfturxsbayicheqlk
sruhcbeqktixvfayl

vam
mv
vm
vm
vm

k
k
k
k
k

ysmikquxzc
yetmlxqsziu

ornk
orkn
rkno
koirn
onyrk

qcajzosf
sofdacj
ajoscf
djfscaeo
fosejac

rkqghbxjdol
uqbdhjkm
jhbd
cbtvadiehj
hfdbrj

nsklymutzivw
mounvbpwdg

sdpgvajmexuyqhcriok
vjksamihwpdrcxqguy
xjsevuydcamkihoqgpr
mjtcnqpgdhvuakfrbxyi

hpoyrxfmcjld
cxlpodryfmjh
jhplfcrydxmo

kembuivdhf
ipefszdh
enclshdbfk
dhreytjwxqgfao

lb
lkr

smtknclagp
pcktnslgam

bfsc
ynbf
hbxklwfep

ye
haybes
ey
eyw

ta
tan
jtap
tah
lcat

ikdqblgs
mtwlvhnbkjsdic
plzskbdi

rctauyzbdklxvpmnwqjfe
plhzdsnbmxqarwjktyfuice

ba
ab
ab
bar
ab

i
i
i
v

ursqy
qrwusy
yrsuq
qrsyu
qursy

cdgrouis
ocrigs

vjwaiph
ypva

yhuqbinztxg
kuqxeogthpid
gtmhiquxlw
gxutsafqbih

wmg
wz

gkpmdtwhnxzaoysjcevuir
hoxmkyqdcwlnvgperszi

oqagy
glxvkq
sdzbreguiwjfm

nabml
pfnyvatk

pu
pu

hbivy
byuv
tueovyb

ozqv
qzon

xjunwvbzdkqy
chfosmgre

dyn
ejxy
xydq
yx
iyp

hskfyqgtbzrvu
yvqhtgbuifrskz
hzjqfuyrbvstgk
zvkhtsfgryqbu

ons
osne
nous
suno

zymjefdwxih
dwxzyfjmieh

ib
bia

ocagmvj
jvcagm
gamcjv
vjcamg

inhlewtdbkxmpaqryg
wnkpxrhlmigtaydbqe
oihnlytpwaxrbqekdmg
mqabydwgterlphnkxi

bjedsywlgnxmpotz
pxejsongtkumzbwld
lpogxznbtwmsjed
tzpuonmjxlwbesgd

wqfsmektu
wmftqs
sqmtwf
tqmscfw
tqwmsf

snkpjbefqwhyriz
ikwrlqymjczfbevntps
qhebojfnzrkwapmsi
begirdpqnjkwuzsf
iqtbhfzpenwkrjs

y
y

gsf
gcsh
ajqgs

ulqbokwrjdcgpthniyxfzmeav
rjbumtoxecngkdvazsfilw

fwsrhjk
hjrfwks
kfjrhsw
jrhkfsw

qktgsvplh
hgol
hgly

qftenaodxkwz
bwtxaqviof

ugzpmhefkj
kgemzusfpjhd
ekfjlhpmguz
kxuepjgonfyhzq
kuzgitlhfjep

jywhzcrqa
otznge
mbuvfsk

iwhekorjgqtsdb
kjgswlbqherodti
okirgdnejtxwbqhs
ezobksgqrajhwdti

rdcoaubxhkitwsvpzygflmqnj
tcnfguzdybojqvwishrlapmkx
smjnpglbkzuafqhtdoxwiycrv
spgnmzlyurchxvwbojfqakidt
kzdtmbslqyvxcrwnauhoijgfp

kvwm
mwvk
kwvm
kvwm

hto
rhg
h
tvhi
vhfk

woxhpvfdlnezi
wemd
cqwkde
sedwuq
wcadtgrbe

moecds
wscmbnoed
sdycmeo

amnqlcytodvreiwkzgfxs
vfwmayqsghdcjztxeornkuil
xgaifqzdvowmknlysrtce
iynsxqwmafdvtklzregoc

ksvejm
eskmvj
ksmjve
vhskemj
ekmsvj

ebfkazr
dgqtkjmw
clykap
zukinrbh

oznuhklqijpmsxfcaryb
hyikolbjusmxqcfnzarp
uzxcbwqshkyamrielnopf

zlpsua
wlzdspu
luzsp

h
hkr
h
lhc
h

zfugqrjipavboys
aurvpzfeosigjqy
srnqiejtoyupgvadfzb
oqryvigjzsuafp
qgowivrzajsupfy

mrotnsaivyxbwp
iapmtxsgbyodwr
woaxsyjicpbtrfm

rdlakocwumetfpjs
cshjuyxwgatvz

wbxauycv
xbwgaove
axwnovb
fwyxmvab
xtiqwbsazvjpl

o
p
p
p
p

ombjurgkvceny
ilxtpwaz

gzjpkewnfylari
nlifyawpzgkjm

ymhesgwkxczrtbjnu
cywuetkbhnsxjrzgm
uwybxgsjnhremztkc

pcsxyiuvfnjbtkqwhlgzr
ixqnskyfwrtlgchbvjpzu
cvuqazjkhbxtlyrnwgifs

ce
ec
cge
ecg
yeh

itfhrlsvgden
svhekgidlrnf
nirlehsgfdv
sginfeldrhv
irsvdlfhegn

w
y

jqwevpgkzhdar
pazkvjqdrwh
urzhvwkpaqd

lsmqgjkb
glmksbjq
qsklgbjxm

iouyxrvbqjcemzlapk
ovlkizemjyarbcupx
zluckepmbrxivajyo
zijoveubxmlpykrcad

tjaruhsdgype
apmetysfkivjblqd

ztxyvufeh
dmcaqrhfgs

qfvujnhtaom
uvqanhfo

dxwvtmlsjqurepbgni
bueiqjanvlpwr
zlryojfupiqvec

dopjewaytmg
amreytdslkgpw
peymdawotxg
uqyahptdxzgecwm
vbohdafmpiwytge

zdkalgubsqw
dsazbkgluw
dsuzgwlbak

fibeyzxkmch
fveymznaik
vtyafiemkz
erlfizymuk

uti
u
gu
u
u

khqjtmswgl
pxnsqzgv

uhkeosrgytcpbvmanqdlwjfz
singwfcorvzadktblmupejqy
lezdusrpwbnfmkvjcxyogatq

nqlmhgrp
e
sw

hrmxwjzg
wzrtpmah
mrewhx
ywkbrnhmci
rhomuvw

cfpsboei
wtifcoybpx
iofcpb
cbpoisf
pcoibf

x
tx
x
xf

etvc
coap

gsbmanzopklyw
zorpislaqbnmywg
awbgczsdxlumypnoh
wtmkgobyaslnzjp
pmjlbsonkfwgtzay

upqwyiagtonfvrsk
dpkvuwoqfaiygsnmtxr
unorfgkpiyasqctzwvh
kbwpyrniohgufqsvat
pfqgsyuhnovktirwja

egkzlwjd
szermjwkl
kaelwjzoq

efmclagdkwhqxrosntzvib
mdhlqfabcrwsgxonizvkt
dhbqlnftivxwapoczskrgm

oxsedbl
zsblx
lrfax

tv
vta
vat
gpmosjtv

ltgeu
tudo
dtuoa
tud

ycsajei
sghikbpmr

bjfohqiwcpd
lzeysr

ghcenrzqksifd
ckwsgdnerfziq
iebsrncqmfk

idbjyxctlgpwas
wgiypblsacjuxd

ivnkjswb
bk
krb
kblc

hbmocfrual
urlfbmocha

mtvwqhag
wtxdcuen

bmdary
wjma
pexakfgu
bhijav
vlmcia

jeaposhgqcblxitkrzyn
aordjqiglcnpvekthsbzy
jhtrkqynszelcoiabpg
jkftnvbgyqploaicsehzr

q
qt
v
t
z

qidvuo
uohvqibd
udivqo
oivduq
vidqou

xjlbhrsnpat
qsavnktzbuldprxh
gxswnpftrehlymi
sahprlxnctz

axqni
aciqnx
xqian
axnrqi
qxnia

tbuicahr
banvchurti
grtbwaihclu

jylfirgmsx
lgfmxjri
xgmklqtfrwj
gxmlsfjr

ayunwcgj
gmcyn
gdtvfioexhys
bgyl
ngqyc

neyazrtkxjhbg
yxjzqknb

diljtqg
qwsnyuabx
qsfhuzv

qzpj
zjqp
qpgzthj
qfzlpjcydxsn

sbkrcjleytuidw
wcbtiljyedmsugk
zubetwdyikjcsl
lwbdieutjkcys

c
c
c
c
t

pdglkmircznxjshwytq
ikqrzgyxtdnjswmphcl
pgihtyjczwdlsqrkxnm

ysj
ysjf
fjsy
sjpy

c
ca
c

fjaounzyrck
uqzfontkrajy
auoyjknrzf

adgezcjtmlwbnkxsp
zlkjswmgabtcenpxd
wedpgjnmlzibkasxct
bkcfsemlqzujnxtgwadp

xrdzvqcyawst
vztcaqyr

p
pw
hpf

syzmig
lqpmnh

qwkysudhal
myk
tykc
ky
ykm

napugxj
pjnuxga
jxpaung
xgjnapu
jnpxaug

xcwklzsdouvejph
wvecjukzhpsnl
uzksblpwigjchv
szkwpncyudlvhfj

mazvxenotrbjpsg
xabenjzrgtmocpsv

amkxogyl
lkmyxgoa
yagkoxlm
awykgxlmo
gxayomkl

euqjn
eijrqnw
qnje
enjq
qejn

qmicpr
pc

mhfelurtibxzg
prcigefthzmbulx
behzitgmxflru
uxgrmzibtelhf
rzfluixbtmegh

trwq
t
zt

yjbcohw
jueqzodyk

tyroqsxepnbfckhuazjdwvmgli
byjcgxmurontvhspekwqildz
svtmwnbighlpxeyokjurzqcd
blprtoqjwnmyuxvdzkeisgch

mrwtb
trmbw
wtmrb
rmtewb
twmbr

jlwri
drwibj
tiwre

cz
cz
z
wusz
zeg

gxqrucimko
zhpqfvbinsy
iqlwdgtje

wyzjqgdihbxar
lwcivxtmaojgbzhp
xzuwgjrabkhfid
ihsaezxgqnybjw

jtair
kfsv
ghze

u
uj
u
u
u

epbvkzsoyqlrifatwch
tfzwlivkhsrbceoqpay
wzcqpotkrhfliavbyes
wvgeufcbopsqymritkalhz

vkaldbmyewi
rcxvlibuedgamy
lysiabjdkvme

nwhqcojkpgvfatderylibxz
hgnoiclkaebtpdfjvmzywx

gafbqnxstirzvoheydmlpwj
hqrukwtozblfyasdxvmnpgei

abpzed
dapzb
wcbdnzapj

uho
nmp

yofngr
amn
n
n
mn

zguhotqnvkepfyabr
okwtbzaqfyen
konyqtbzefa

inbtkepjylqdfxczmoauw
mzolcwaxfnbditkejpuqy
zjyoifdkmcaupenbtwxlq

yuzri
rubyi
yiur

otdbszvjhecrkiypn
ydmovicrbzfkeshqng

efc
e

orbzu
iszurwb
becjrkzup
irlznub
xbtragfdyqz

fpj
pfrd
fpr
fpwc

rklcfn
nflck

li
sli
ik
i
isv

awuhgmb
jznsiqycker

y
y
vmpdu
ok

jeionpfgkvxdmrzlyc
diblznsykpuxwqfm

mlykav
vmka
aqvrkdm
vkmiaz
rmkdvaq

uyljahgbxsvczpkdq
rowf
ntemi

xjhaitwlozdpcbv
dvnzjxblpcahoiwt
xbwdolatjhvczip

spohauibt
ipsatqnozlxvub

vuzf
fchz
zf

almqujgzovhyfkbwtindre
zvskmgitqyweoldjufranbh
jrkeqfanmvoiwblzdthguy

y
y
y
y
y

fsqxhnbtcdy
bhkqnvxdws
qsdnxihbm

c
cvip
wcqp
xrkjc

cbsfeonkqthadzimpwyg
wkybvhdsnaztcgefpqom
dipbljsqxfecakmtyoghnwz

ocxiztfw
djhaepyqu

pbyzfvq
rpqzvf

p
p
p
r

fgj
mghx
cguivrnzdw
xhmqlgf

lypf
fpyl
npylwaf
leupfy

rxyzatoj
xvfin
bxlfk
ucbqx
lx

rkixw
fk
mk
kmybf
vkqg

macdvsjophnzixyukwglqef
uhkdzsyecoixjpgqvanlfwtm
nszgjudxpfchoameiwrqylkv
hgkswmlvjyufeipaxnoczdq

hkvtprgxom
mxitpvkgdrho
mphkortnigv
kvtprlhmogd
kmverqtohgpwj

krsazmfbdtxyuijh
iebqjdruma
dimbrjua
imjurdab
ajrbuicdnvm

jzroas
vwo
om
kmvo
fo

vckphlabort
ktprcvabohl
tabrkohlcvp

lb
j
xi
p
i

ibxswpzlgak
pablwzkxs
kzablwpxs
xapzsbwkl

texidwzkyjcapn
djptyzcernia
narcjoiteqzdp
cetbjpzavigmnd

thxzfeocaqpkd
rvgoyxzlk
zkox
kxuzngo

dqsofevyrijctbxzwkghn
kjwvnobzergsihtdycqxf
robqyvzihwjsxcdfektgn
octvjeshdiwbyfngzqxkr

f
udzlmcrjehivqpx
agn
owb

vokdu
dck
knd
kd

txqlzrv
tvxlqzr
vxaqzrlt
tcxrzvql
qtzvxrl

flnc
lsk

agqspncoikwytuvre
muyijzoltcepsaxkdvhbgf

gmlyx
gakyvsl
cdthyjrioubq
myl
awezy

dfzvhkblgnj
kvzjdfgbnlh
hdknbjzfvlg
jkgvnzldfbh
jzkhfvgbnld

jvdkxqsrio
rpuqvkncfgzit

oqzmkjb
glehuw

stweunormcqdyivabxk
plgihfuzjbr

fiakobrucnqyjtxsvmw
utcfankbwvozqjxy
vqknowtacjbxyfgu
qboaxvykfcjtuwen

lqxfvjncarmowzst
sgpnhq
spnyueq
kqns

plis
i

alqp
dpml
ycntviwgf
zkeau
pkxo

cahvspxi

dgyk
kydg
gycdk
ygkd

ygxdtqsiralczwmfoke
fqeoltimdykzgwxrcas
mlrzsgafxqcidkweyot

ibpuxwfrnjygadl
ucbjmfziyklnrdxw
wbqrxjdihesvyunfl
zfubxtylwndjrpimo

ahdf
aq
awjyc
as
nah

klygiqmwhzubproas
dhetbmfiazsqrwclvugpk
ugnkxpmqirhswazlb

n
otzi
q
o
dkfx

gwoidjb
sqownkvt
oywgjxa
iwoeh

kcsfhg
gfksc
gcksf
pcgsfdk
hsckgf

lzgtrfpsxwqhi
yqzovtixp

mqyhlxgfnbtcvwejpsrdouzik
simkqtcevpohxdygbjlzrnfuw
dprugmhqkcwveixoyjbstznfl

m
m

akmrpwutnb
lnamrphkwtf
rpumnazwkft
kwrtmpvan
mjakwnsxrpt

kgstyrbauzjiqfmdl
rlpubyfadxmtijgswzcqk
bzsfnumiadjykeltgrq
qfavbdhujrglyzstkmi

zvxca
xazcv
avcxz
twxcavzk
vxzoca

kyjbqhd
yqg
mleagqy
qnlgy
rvqya

rkbfpejgaqunlhy
hogsunxedrlkbaj
ktzjmaugrnhblie
rbkgnajlehu
qelbwhuragjnk

pkbrlq
fhlvcetzujqo

dbpnjmfgzuaky
qrmnapvjswgyzfecl

oubx
uxb

k
t
ce

qo
oq

nrdoliybfmk
xbfonlytdi
odbyanilf
zdyinxfbrlmv
bnfgwdiyls

ptqr
yhpr
oifcxpumwares
rhbp
vrp

edmfbockpuzjl
mejpzldckfoub
bulkamoepdzjfc
wjblknodpmczufe
plbzukcxvdhefjmgo

sbfvdziayohutkxmcepnjgrwlq
slqbthaugnxcfejkymrpvdzwio

ovnuybcjzw
cubyavn

jlpyfemohwb
ympjolewhfb
hpjymbwolef
hmfewypjlbo
yjwlomhpfbe

yudoticgpmswxheb
imctpdhksgwavxbefuy
ytmhucixswdegkbp

femhgtsc
hgetcp
gct
schmgt
acogbzt

jdfzyhgnks
kfmgndbypsjz

qxkrsvfih
xvirkqfh
kxirvfqh
phvuixfqrmt

jwq
ovwjq
azpjnys
hjw
j

mekjycug
okyicj
jevq
dzsharjxltp

ageqsriyfoupknldjz
bqkjhmi

arqoszdiyemtlpbcukxhg
tskxzcqmelhorypiua
ikcwsfalhzymorqxpetnu

o
wj
o
o

hoqrjzemyfidak
hdofikzyrjqaem
amyjorkehdizqf
qyajdekzmfohir

rfgtpasbvquzykj
kwdcasjtyvzfuqegpib
tpangskbuorqyjfvz
qubhzfvakospgtyj
tjgvuayzfprksbq

xvsetimqaglzhubopjnkrw
vretjpaqgzidoulbmxhknsw
kxzwjmscaeulgqnpovihbrt
riwnepagmhktvusxqljobz
tugmqkbasnzhjivrlpwoxe

yawojch
aoyhjwc
wjcyoah
ocawyhj

atfkezomu
bwghcxijm
lmydqzvnpr

nfajymk
yakjmfo
skayfjm
ayjvkmfti

zbcgaxyjd
emltdhkwsug
dqgfnue
qgnvd

ibecm
ecmbtfislo
cxympeuib
iacrepxbm
ckibme

ednxkzblgoqwrys
naklxbrzsodqegwjyf

mabnelwrzy
keandpqxbmlo
gviuhjstf

xlzoysmpdgfcabiqetr
mplwsgnxcadzfhukvrqjeybo

l
l
l
p
l

zyjuwao
odfv
skqoc
omvrcqbh

fgpcjvmbxuiwtehnd
pcfsgtxbnkuihadm
cdgtfhbmxpuni

e
ea
p

ild
ld
ld
ld
lhd

hwelutk
wshulk

milbjvxorn
lbivoxrnjm
mjxivlrobn
ilxmovnjrb

inhcdkotgs
syndfwkghteico
gkhdiczostn

jgpmfyqskc
kgfyqpsmcj
pyfckjgmqs
gskpcqyjfm
pyqsjmcfgk

opbqxluhyvskn
xonskvbpuqhyl
vnijlhyqpxukgosdb

dzglxpfnt
nfptl
qynmuvrcp
zdnpk

ligcsyexbdoqt
educotylzjb
zuyockfnbhtedml
owlyuabectdf
ycdrabolte

hw
qr

utqdisoacyr
jgnbvzwmhekfxpl

s
i
i

ovbhcfp
oauvcpte
qowxkpnyjlvdismc
zvctogpfa

qtsmhpwz
qchasetf

ysmvb
byvsm

yjkvnlqcpgasibtex
ycjgqedpvnx
nuygpfzhvejqdxc
qwyjenxfvpzmcgu

tlribvnydjfex
rmpjdqsbzgcxv

hn
uhn
nh
hn
hnz

yvzrqpbel
blejaozvmypr
ebrlvfyzwp
brzpyelfv
zwbpyervlf

rtgnjiawecpmu
ejcnpgtawuirm

qhuybzmv
pnwzceb

cuijneskratyqgwxmodzhpl
wtqshpyzrcmokixgjbenf

wrthvasmxk
hvktmsarx

s
sp

td
rvjitl
tdpk
t

mgdaqpzefbxh
xfbmeadgzqcn
eragqjmlofxysdt

cvzxwpf
pxwuef
lxswpeft
wxpf

eqckjbluvodhtg
cvgujlhekoidtqb
bhdoltuvgkqjce
vhgjcektdbuloq
jdogqblchetukv

hmgwcszjqpyxil
wzplksghxcmyji
gkiczwmlyjxsh
jsgxcmzhlyviw
ujihlsyxgmdzcw

ofrubwjqkxpzaitevscmgyln
bigsuetvkorzqpajxwfldncm

qink
inrkq
knqi

jvnayiodwg
dos
tmhzeqdpo
hods
bohdklfu

i
i
i

ndwutoamyzbrpqsveg
zbdswnrevapmgty
zdtpnymegawsvrb

obwzklcynjgme
zlkeyfcgwmjn
icjzemnypwklgo
munwqycgzkelj
kcnzjsiylwpxgem

nbaeiqstvdwmhjukx
njxvowhqdfabieskmuzt
wbnsutjqdhgevkmixa
ycjswbkaqmvixlhutned

okcwymdgvfhlxzt
odygvtkmlwfxzch
wcmgjhdflxotzkyv
kaxyfglvwmodzcht
dxcafvltwokmyzgh

rejdmivax
xdamjver
ejvdxmar
rjmedxva
edrvajmx

lkqgnc
lnckg
lkgcsn
wklnhcg
lcgkn

upnosleiz
pnlszwe
esjpdnlrm
hnletqakgpsb

fb
f
f
frz

d
d
d
d
d

lyqavutgbwiehjrc
qcragbvihujlowtpy
tzyjhawliuvbqdrmgc
rglvzjtuidbcywqamh

edolzs
luoeshd

v
v
vg
v
v

scwuqekdbmarfiy
nzoxvptg

ycpvjeubrazgiodxtwn
cptzsxjmklyvdeaonbqiwr

kbmqslrvnyzpj
slxfnbqpjy
jsypwbnlq

xv
oxv
xv
vx

ulzdr
zoshulr
xduzr
zrqju
tzurvebgc

vp
v

n
fn
n
n

bmpfnxzsajwvyhqldrecout
rvnpsoxzlcmeufthkjayq
hozncuervmgqpyfatjxls
ovrxesptqajlzycfnmhu

lfjc
fc
fc
fc

jdhrx
jranxydbgt

y
y
y
y
y

tpfydje
ejpdfy
jyepdf
epjdyf

b
gphf
e
uvkc
jza

glyxuj
gjulxh

ubmeofqsxdangrchivy
yhcueqvgfasordxmb

vbtex
ubenvxzkt
txbvae

yoxb
byoex
obxky

vxhroygampneuzslckibfqdj
jqfcvnaizeluhkmrdxpy
eidxrkcnvjzhpqymaulf

dtlpjkfar
sjtprafdyel
afpgjtvlr

z
b

rwutpgkyanm
nwatgkmpuyr

jb
bj
jb
bj
jb

yvcbs
csvybh
bsvycu
csjrinybgpv
yhsvbocw

tapdxjkbuhn
uqoaigmtphcfv

gbrf
bgrf
grfb
brfg
rfbg

lhj
r

nsuvr
rntus
rnmdcsu
nusr
usnvr

mglncfrspjxqdheatkby
awokdbmlvurnzjecqsyxpth

dkphrovicb
oihkdcrvpb
kcdvhbipor
ichrbdpvok
prckhibvod

obaxmnut
otabun
haobdtun
pvfnztekujcbqyoa
tibmhoagun

mvhtqgsxc
ztljokabwni
tdyuefmqrp

gdx
jnxk
x

bwfpeojrtnqmszhya
jfduwroxmenzhky
mhfrjediyznwclokv
hfjirnwymekgzo

bzcpqi
ipcqbh
ciqpb

vbnegldq
ebgvq
equxgbv

pmcjwzqsrgye
svhujyprdftb
pjsnaryo
onsrpjy

dfqbynoxcgljpuhaesmvt
dxhecqampgnyultfjosvb
cifqxleudmvjhgaspybotn
snqvtgaphyfloxeucbdjm
ayetuxbogqcmfnsjvhpld

woqjbvaesrh
rmjaeswobqv
rqeswbjoav
owebqrvajs

fsgejt
jskg

obzeufrsykvjdqg
jqaiozpwrmbsdxkf
sjqdzfktbrlho

awqldosnzykc
dolsawqncz
wodsqznacl

ohtxrakybsecjnqviwduz
mwodbqsxihrajpcztygluknfve

m
mv
amq
m

ahoubdnlywcigjt
cynbhdivwtoglaju

bpgewx
zxpubsdwq

adhjekz
tzjkde
ewkvzjd
tvefjzdk
ejdkz

uetkosjndqgxcyvm
mclnrsaxjytqvdpg

kbhed
dix
afdt
d

xhd
hgrd

rbyavgzjflhdinqesk
snkvihbalfryjzeq
zhaivknreqfjsbly
brkljfziyensvaqh

bokdlygwhafrc
xwuronlpakqi

pnwsxh
pnrwsxh

yhrqpsbjv
dav
iwuoxlgfc

hwge
ihwejbsv
zneltwyrhfkaom
ewxjvh

oxnscztqjyafr
hyxnkjvwrufcm
pmcgrnulkfjvxy
berfkxyucijn
wencyxrfhlj

kilhnpjvdofbatcz
rhgvxiwmncfez
vizhucnqfe
cnhzivfu

umxzfpvkb
vpkxumbzf
xzkvmfbpu
uxkfzvmpb
pfxvbumzk

vmsdxahqipznu
fupiasyvlnxjzdrhq
unhagxpkvdsqzie

vdwyb
vyudwb
cdywvu
ydvw
vwjdayh

d
d
d

qlfcbhrvw
fzrbyuc

jcsonk
uckosn
kcsno

sawivom
ioas
aois

weluyo
qhcprdvg
sbkwuy
uzynje
najxiue

xbrfmeznhowj
tbycldqagk
uivcbs

uzgpwofxcaqidhntlmb
oidfhxgbnluzwmcptq
tquhizxngoacdwfpml
ldztycveqghipmxsnfowuj

n
qn

fqu
df

cxpvzgfyijsaoltueqkm
ajuxlvozygsfqpteicmk
ozeafkvtlqipjugyxsmc

z
c
z
r
z

jsapzgufkmwvdibqt
aerhpisyudxgmvwbjo
pvnudbctjgfwialms

auylqgmpcfbkihesz
zislkfqgapebch
fleshzgkqbaipc
hpnszqkiatefclbwg
esxlhdzvbfwkpagqci

j
x
x

vcypdnobl
kfabxw
wjqbig
ibzm
kb

hkodlmsgqbzjevcfayi
vfyticqwblkjsuagdpozme
ifdqbksjrxlegomhnczvya

bktgaefp
rexytwau

xwasezkctrov
pcsxbrzhdtw

gzkcdewab
lmd
xyftvqsidhur

kbvzwsdcn
pkbszvw

jsvouxke
qgzi
adrbyz

zvqpbkanyjwgtueflcdrx
cpyqrwgtjafuklzxndebv
wzdgljoaycekvbptuqxnfir
djrguhfbptyxkzceavnlwq

nhqgxmdsl
vtzpkmqdfl
uqomrjelw
zflbvqm
alxmq

smlxpqfh
tkszqhlvm
qjomlvks
qwduyrbsnlim

wpkcvmxuityzqgjdeofb
fvkyxbjdumoptiqwgecz
pbdvuetqczokmxfgywij
zifybkeudwvqgxjmcpot

porctbafwqzedgysxljkhv
jxbdhgqkftnyalsopzvwce
kozvgtxejlcpdhqsyfawb

obduynsxf
dysbxonuf
fbsoduxny
ubycdxnofs
bfysonxud

his
vfxa
xa
fax

yolm
bo

jotsmh
xfqhsbvrolc
hsgdaoz
jotyhsu
szoh

dz
dz
dz
zd
zdk

idykem
asftdpu

fbvmunwkreldcy
blaqkxzvyim
ilbvmxjkysq
laiymvoqhbgk
vpklbmyg

jvsmlog
jgwvmsplo

risldpqb
lbsiprxo
bsiprkl

nzcybwkpah
yhwcpkzna
wzhcnpayk

ixfbamn
inb
ubinke
ncbkei

elchnpjkxwtqig
nljgiceqahbx
lcugbexhqjin
idxjhmeqclgfnv
fqlhcexigndj

vmgcneztlbs
qeblzmvcngst
ngbclszmvet

ckn
c
c
c
c

yezpv
wyvlez

hfdtkslevcwnoxzi
tsfekmdjvclihzwno
etsiwvnzlkfdhoc
ckfotsdnzivhwle

e
y

cdbn
bcnd

hbupimtkawejgvfzcnoysx
zfnkwbpvchoxietmujsyg
jmehbtwivfznkupxcsgroy
gomuvnyjhwekscizbtxpf
hspzxkncvfitwjguymebo

qjw
j
rosg
jt
qjxe

s
js
s
s

sudlgxvitacpyfhkr
isuvgfkrchadnj
gvqfzrmdihucsak
qgrodskhauficv

rqefisluvyg
nyjotwizfk
iayf
yifd
ftyij

alxbdhwiscq
qgcjrwezay
ahwitmqdcu

d
d
yxl
d

zwfdsuqc
dzcw
cszudw
hzdlwb

axv
vx
vx
xv

nrw
blzfvgh

pe
elqmzvgfk
e

ygfk
xdjnublae
r

jvn
nvj
jvn
vjn

mblaqhitwdv
bljivaqxthdw

d
dc
d
d
d

e
d

vjsrl
jrlvqseb
vlsrj
lvrsj

cjfta
ajfct
tjcaf
fjbhatc

dqbfeprkzgvt
tpbfkdrqge
rwaqfedxkpbgt

owbmusnzvgpf
orgvlwkyxp
tvpwohg
wtgqcovp
gpavywoie

gczomkqlvdbn
aolduzmgbqvyec

tynrkjlgsq
qsnlytrkjg
yntgklrsqj
tygrlsnkqmj

pyfrutmwb
ubwnsrfy
yfwrspb
ydvborwf

qlsmcbh
hqlmcsgb

cowjnufayrix
rqaynwxfcoj
xogamefhkdjyrvwcnt
afrznwocyjx
cuirsyxfwloajn

htosau
bvkdcr

ewyzhgipl
lwezhbingydpk
hpzwmijeygl
ieythwpglzm

ozjphrbglsi
rguphzjoyil

b
o
ru

ritlagqevs
itslgaw
gvjsalitr
uixaolkghst

pnjoxwlurzkytdcb
jucwnytzoxbrpldk
lxpboczwtduykjrn
pyzkdnxoljvurwbct
rzupcbnxkwoytljd

snpvyotqzxubard
qorubpavdnxytzs
txpvazrqubnydos
vaotxpszyurbgnqd
pzxurabtqsvnoyd

wcybutsgnvxlpdjrmeko
ursvnedtgjbylckqwoxm

otac
cot
otc
toc

np
ndtfblp

uvaeirsy
vryjispm
smuiry
fzdbyqsrtig
rwkmycveis

jhutgyv
juyhtg
ytuhjg
hutgyj
tuhjyg

zxwyodcm
dwzyomc
wmdoczy
wxymojzdc
ylowdcmvbgz

tjefad
yokb

akbwzocshvu
kchubzawyvos
zbwukohvqasc
hzkbucowsav
zykvhoauwbsc

qsy
jq
pq

bnkryxpdvswjagzhfqtil
kgfawvzjinumhldqpytxrb

yfdr
yfrd
royfd
dryf

wsvptxyhcqfa
fysovtqwxchpa
vahfqtpsywxc
wfqaptcsvhyx

wezkdnqhgufvarycxijlobs
rzoicqxglbfhenksjwv
gwikzclbvrxsnjfoheq
hwexrfocgnjvqbzklsi

dm
yk

xyqbn
cxypns
hkgylf

mhqunico
mchio
hciwosm";

            #endregion

            #region MyRegion

                 var input2 = $@"abc
     
     a
     b
     c
     
     ab
     ac
     
     a
     a
     a
     a
     
     b";       

            #endregion
            
            
            var blocks = input.Split("\r\n\r\n");
            List<int> sumInBlocks = new List<int>();
            
            var sum_string = 0;
            foreach (var block in blocks)
            {
                HashSet<string> uniq = new HashSet<string>(); //хэшсет со всеми уникальными знаками блока  
                var string_in_blocks = block.Split("\r\n");
                var contains_str = string.Join(string.Empty, string_in_blocks.SelectMany(x => x.ToString()));
                contains_str.Select(x => uniq.Add(x.ToString())).ToList(); //Теперь HashSet заполнен
                foreach (var str in string_in_blocks)
                {
                    HashSet<string> currentChars = new HashSet<string>(str.Select(x => x.ToString()));
                    uniq.IntersectWith(currentChars);
                }

                sum_string += uniq.Count;
            }
            
            Console.WriteLine(sum_string);
            Console.ReadLine();
          

        }

        private static void Task_8_1()
        {
            #region input

            var input = $@"jmp +236
acc +43
acc +28
jmp +149
acc +28
acc +13
acc +36
acc +42
jmp +439
acc -14
jmp +29
jmp +154
acc +16
acc -13
acc -16
nop +317
jmp +497
acc +21
jmp +386
jmp +373
acc +22
jmp +311
acc -16
acc +27
acc +21
acc +43
jmp +512
jmp +218
jmp +217
acc +12
acc +44
nop +367
nop +180
jmp +134
acc -2
acc +42
acc +13
acc -11
jmp +442
nop +457
jmp +151
acc +15
acc -4
acc +0
jmp +131
acc +6
acc -2
acc +37
jmp +112
acc +32
acc +6
acc -15
jmp +474
jmp +515
acc +12
acc +11
acc +4
jmp +339
acc -3
acc +36
jmp +220
nop +91
acc -12
jmp +49
acc -17
jmp +204
acc +40
jmp +535
acc +37
acc +8
nop +147
nop +174
jmp +306
jmp +305
acc +7
acc +33
jmp +305
acc +22
acc +17
acc +24
jmp +458
jmp +1
acc +36
acc +34
jmp +113
acc -3
nop +113
nop -34
jmp +506
acc -19
acc +21
acc +35
acc -1
jmp +74
acc +15
acc +7
jmp +79
acc +29
acc +42
jmp +427
acc +33
jmp +29
acc +6
acc +13
nop +477
acc +26
jmp +493
acc +33
acc +43
acc +49
acc +35
jmp +409
acc -7
acc +35
acc +40
jmp +309
acc -13
acc -14
acc +32
jmp +322
jmp +10
jmp +44
acc +20
acc +25
jmp +175
acc +22
acc +16
acc +1
acc +36
jmp -65
jmp +231
acc +35
jmp +155
jmp +218
acc -10
acc -13
acc +38
jmp -92
acc +15
jmp +134
acc -16
acc +18
jmp -30
nop -41
acc +48
acc +49
jmp -107
acc +4
acc +34
acc +38
acc -18
jmp +247
acc +45
acc +23
jmp +149
nop +164
acc +26
jmp -24
jmp +240
jmp +77
acc +30
acc -13
jmp -158
nop +136
jmp +33
jmp +189
jmp +143
jmp +1
acc +4
acc +30
jmp -106
acc +16
nop -52
acc +37
jmp +119
acc -11
acc -9
acc +15
acc +4
jmp +301
jmp +1
acc -3
jmp +188
nop +86
nop +125
acc -10
jmp -105
acc +36
acc +9
acc +0
jmp +317
jmp +347
acc +48
nop +380
acc -18
acc +28
jmp +398
jmp -152
jmp -86
acc +22
acc +11
acc +39
jmp -173
jmp +343
nop +194
nop +98
nop +382
jmp +300
acc +35
nop +287
acc -8
jmp +302
acc +19
acc +45
jmp +95
acc +29
jmp +274
acc +18
acc -13
acc +23
acc +7
jmp +164
acc +17
acc +36
acc -5
jmp +153
acc +21
jmp +105
jmp +1
nop +267
jmp +277
jmp +88
acc +2
acc +18
nop +182
jmp +189
acc +37
acc +46
jmp +258
acc +22
acc +15
jmp +249
acc +17
jmp -162
jmp +25
acc -6
nop +314
jmp -30
jmp +312
acc +34
nop -230
acc -2
jmp +158
acc -4
acc +37
jmp +318
acc +18
acc +23
acc -8
jmp -248
jmp +181
acc +17
acc +4
jmp -189
acc +27
acc -13
acc -4
acc +8
jmp +222
jmp +310
acc -5
acc +35
jmp +241
jmp -130
jmp +124
acc -19
jmp +331
acc -8
acc +45
jmp +106
acc +23
acc +48
jmp -107
acc +7
acc -19
acc +3
jmp +130
jmp -104
nop +5
acc +29
acc +8
acc -6
jmp +7
acc +12
jmp +102
acc -4
acc +46
acc -17
jmp -209
acc +20
jmp -271
acc +48
jmp +30
nop +204
acc -19
acc +4
acc +38
jmp +17
jmp +116
acc -17
acc +23
jmp -75
jmp -129
jmp +152
acc +36
nop -193
acc +26
acc +38
jmp +242
jmp -197
acc +32
acc -5
acc -19
jmp -201
jmp -304
acc +9
jmp +175
acc +1
jmp -15
jmp +1
nop -74
jmp -38
nop -165
acc -19
jmp -317
acc -19
acc -1
jmp +17
acc +0
nop +151
jmp +93
acc +32
acc +29
acc +0
jmp -340
acc +39
jmp -115
acc +0
acc +47
nop -320
jmp +244
acc +29
jmp +81
jmp -84
acc +2
acc +16
nop -345
acc +23
jmp +9
acc +26
jmp -67
acc -11
acc +38
jmp +150
acc +19
acc -2
jmp -244
jmp +88
acc -4
jmp -157
acc +22
acc +33
acc +41
jmp -117
acc +31
acc +50
acc +24
jmp -265
jmp +1
jmp -352
jmp -312
acc +35
acc +30
jmp -90
jmp +8
acc +14
acc +39
jmp -112
acc -11
acc -3
acc +22
jmp -116
acc +48
jmp -194
acc -5
jmp -252
jmp +66
jmp -295
jmp +196
acc +25
acc -11
nop +112
acc +33
jmp +123
acc -10
acc +28
nop -119
acc +12
jmp -166
jmp -356
acc +8
acc +16
jmp +161
acc +25
acc +3
jmp -5
acc +32
acc +40
jmp +181
acc -11
acc -5
jmp +1
acc +0
jmp -265
acc +5
acc +24
acc +15
acc -17
jmp -326
nop +103
acc -9
acc +13
jmp -379
acc +38
acc +16
jmp -65
jmp +1
jmp +1
jmp +1
acc -1
jmp -191
acc +35
acc -19
acc -6
jmp -52
acc +15
jmp -357
nop -134
acc -3
nop +103
jmp -123
acc +43
acc +0
acc +47
jmp -373
acc +0
acc +50
acc +44
acc +21
jmp -114
acc -19
jmp -339
acc +25
jmp -410
jmp -126
acc -2
acc -6
acc +14
jmp -207
acc +35
acc -7
jmp +75
acc +9
acc +22
jmp +114
acc +18
acc +36
acc +0
acc +40
jmp -192
acc +35
acc +0
acc +28
acc +3
jmp -346
nop -131
acc +46
nop -467
nop -179
jmp -151
jmp -120
acc +30
acc +22
acc -7
acc +18
jmp -157
acc +5
jmp +76
nop -315
acc +25
jmp -357
acc +44
jmp -12
acc +0
acc +19
nop -485
jmp -495
nop -115
acc +12
jmp -8
acc +31
acc -7
jmp -158
acc +44
acc +32
jmp +87
acc +1
acc +37
acc +44
jmp -86
acc +0
acc +17
acc -13
jmp -434
acc +37
jmp -342
acc +3
jmp +1
acc +29
jmp -242
acc +48
jmp -442
jmp -283
acc -19
acc +6
acc +20
acc +44
jmp -533
acc -15
nop -356
acc +18
jmp -408
acc -9
acc +17
acc +16
jmp -385
nop -130
jmp +1
acc +38
acc +39
jmp -324
jmp -141
acc +4
acc +3
acc -4
jmp -114
acc +2
jmp +1
acc +44
jmp -360
acc +43
acc +36
nop -177
nop -288
jmp -496
acc +45
acc +0
jmp -322
acc +13
jmp -511
acc -2
acc +36
jmp -460
acc +28
acc +28
jmp -455
acc -4
acc +38
jmp -145
jmp -163
jmp -331
nop -227
jmp -470
acc +35
nop -419
acc +39
acc +0
jmp -435
jmp +1
jmp -69
acc +20
acc +46
nop +2
jmp -239
acc -3
acc +12
acc +38
jmp -259
jmp -60
jmp -67
nop -542
jmp -397
acc +32
jmp -57
acc +30
nop -393
jmp -380
acc +16
acc -7
acc +0
acc +2
jmp +1";

            #endregion

            var split_string = input.Split("\r\n");
            List<(string, int, bool)> sortedList = new List<(string, int, bool)>();
            foreach (var line in split_string)
            {
                var two_items = line.Split(" ");
                var item1 = two_items[0];
                var item2 = int.Parse(two_items[1]);
                var item3 = false;
                sortedList.Add((item1, item2, item3));
            }
            // теперь список заполнен

            var accumulatorValue = 0;
            for (int i = 0; i < sortedList.Count; i++)
            {
                start:
                if (sortedList[i].Item3)
                {
                    break;
                }
                if (sortedList[i].Item1 == "nop")
                {
                    sortedList[i] = (sortedList[i].Item1, sortedList[i].Item2, true);
                    continue;
                }
                if (sortedList[i].Item1 == "acc")
                {
                    accumulatorValue += sortedList[i].Item2;
                    sortedList[i] = (sortedList[i].Item1, sortedList[i].Item2, true);
                    continue;    
                }
                if (sortedList[i].Item1 == "jmp")
                {
                    sortedList[i] = (sortedList[i].Item1, sortedList[i].Item2, true);
                    i += sortedList[i].Item2;
                    goto start;
                }
            }
            
            Console.WriteLine(accumulatorValue);
            
        }
        
        private static void Task_8_2()
        {
             #region input

            var input = $@"jmp +236
acc +43
acc +28
jmp +149
acc +28
acc +13
acc +36
acc +42
jmp +439
acc -14
jmp +29
jmp +154
acc +16
acc -13
acc -16
nop +317
jmp +497
acc +21
jmp +386
jmp +373
acc +22
jmp +311
acc -16
acc +27
acc +21
acc +43
jmp +512
jmp +218
jmp +217
acc +12
acc +44
nop +367
nop +180
jmp +134
acc -2
acc +42
acc +13
acc -11
jmp +442
nop +457
jmp +151
acc +15
acc -4
acc +0
jmp +131
acc +6
acc -2
acc +37
jmp +112
acc +32
acc +6
acc -15
jmp +474
jmp +515
acc +12
acc +11
acc +4
jmp +339
acc -3
acc +36
jmp +220
nop +91
acc -12
jmp +49
acc -17
jmp +204
acc +40
jmp +535
acc +37
acc +8
nop +147
nop +174
jmp +306
jmp +305
acc +7
acc +33
jmp +305
acc +22
acc +17
acc +24
jmp +458
jmp +1
acc +36
acc +34
jmp +113
acc -3
nop +113
nop -34
jmp +506
acc -19
acc +21
acc +35
acc -1
jmp +74
acc +15
acc +7
jmp +79
acc +29
acc +42
jmp +427
acc +33
jmp +29
acc +6
acc +13
nop +477
acc +26
jmp +493
acc +33
acc +43
acc +49
acc +35
jmp +409
acc -7
acc +35
acc +40
jmp +309
acc -13
acc -14
acc +32
jmp +322
jmp +10
jmp +44
acc +20
acc +25
jmp +175
acc +22
acc +16
acc +1
acc +36
jmp -65
jmp +231
acc +35
jmp +155
jmp +218
acc -10
acc -13
acc +38
jmp -92
acc +15
jmp +134
acc -16
acc +18
jmp -30
nop -41
acc +48
acc +49
jmp -107
acc +4
acc +34
acc +38
acc -18
jmp +247
acc +45
acc +23
jmp +149
nop +164
acc +26
jmp -24
jmp +240
jmp +77
acc +30
acc -13
jmp -158
nop +136
jmp +33
jmp +189
jmp +143
jmp +1
acc +4
acc +30
jmp -106
acc +16
nop -52
acc +37
jmp +119
acc -11
acc -9
acc +15
acc +4
jmp +301
jmp +1
acc -3
jmp +188
nop +86
nop +125
acc -10
jmp -105
acc +36
acc +9
acc +0
jmp +317
jmp +347
acc +48
nop +380
acc -18
acc +28
jmp +398
jmp -152
jmp -86
acc +22
acc +11
acc +39
jmp -173
jmp +343
nop +194
nop +98
nop +382
jmp +300
acc +35
nop +287
acc -8
jmp +302
acc +19
acc +45
jmp +95
acc +29
jmp +274
acc +18
acc -13
acc +23
acc +7
jmp +164
acc +17
acc +36
acc -5
jmp +153
acc +21
jmp +105
jmp +1
nop +267
jmp +277
jmp +88
acc +2
acc +18
nop +182
jmp +189
acc +37
acc +46
jmp +258
acc +22
acc +15
jmp +249
acc +17
jmp -162
jmp +25
acc -6
nop +314
jmp -30
jmp +312
acc +34
nop -230
acc -2
jmp +158
acc -4
acc +37
jmp +318
acc +18
acc +23
acc -8
jmp -248
jmp +181
acc +17
acc +4
jmp -189
acc +27
acc -13
acc -4
acc +8
jmp +222
jmp +310
acc -5
acc +35
jmp +241
jmp -130
jmp +124
acc -19
jmp +331
acc -8
acc +45
jmp +106
acc +23
acc +48
jmp -107
acc +7
acc -19
acc +3
jmp +130
jmp -104
nop +5
acc +29
acc +8
acc -6
jmp +7
acc +12
jmp +102
acc -4
acc +46
acc -17
jmp -209
acc +20
jmp -271
acc +48
jmp +30
nop +204
acc -19
acc +4
acc +38
jmp +17
jmp +116
acc -17
acc +23
jmp -75
jmp -129
jmp +152
acc +36
nop -193
acc +26
acc +38
jmp +242
jmp -197
acc +32
acc -5
acc -19
jmp -201
jmp -304
acc +9
jmp +175
acc +1
jmp -15
jmp +1
nop -74
jmp -38
nop -165
acc -19
jmp -317
acc -19
acc -1
jmp +17
acc +0
nop +151
jmp +93
acc +32
acc +29
acc +0
jmp -340
acc +39
jmp -115
acc +0
acc +47
nop -320
jmp +244
acc +29
jmp +81
jmp -84
acc +2
acc +16
nop -345
acc +23
jmp +9
acc +26
jmp -67
acc -11
acc +38
jmp +150
acc +19
acc -2
jmp -244
jmp +88
acc -4
jmp -157
acc +22
acc +33
acc +41
jmp -117
acc +31
acc +50
acc +24
jmp -265
jmp +1
jmp -352
jmp -312
acc +35
acc +30
jmp -90
jmp +8
acc +14
acc +39
jmp -112
acc -11
acc -3
acc +22
jmp -116
acc +48
jmp -194
acc -5
jmp -252
jmp +66
jmp -295
jmp +196
acc +25
acc -11
nop +112
acc +33
jmp +123
acc -10
acc +28
nop -119
acc +12
jmp -166
jmp -356
acc +8
acc +16
jmp +161
acc +25
acc +3
jmp -5
acc +32
acc +40
jmp +181
acc -11
acc -5
jmp +1
acc +0
jmp -265
acc +5
acc +24
acc +15
acc -17
jmp -326
nop +103
acc -9
acc +13
jmp -379
acc +38
acc +16
jmp -65
jmp +1
jmp +1
jmp +1
acc -1
jmp -191
acc +35
acc -19
acc -6
jmp -52
acc +15
jmp -357
nop -134
acc -3
nop +103
jmp -123
acc +43
acc +0
acc +47
jmp -373
acc +0
acc +50
acc +44
acc +21
jmp -114
acc -19
jmp -339
acc +25
jmp -410
jmp -126
acc -2
acc -6
acc +14
jmp -207
acc +35
acc -7
jmp +75
acc +9
acc +22
jmp +114
acc +18
acc +36
acc +0
acc +40
jmp -192
acc +35
acc +0
acc +28
acc +3
jmp -346
nop -131
acc +46
nop -467
nop -179
jmp -151
jmp -120
acc +30
acc +22
acc -7
acc +18
jmp -157
acc +5
jmp +76
nop -315
acc +25
jmp -357
acc +44
jmp -12
acc +0
acc +19
nop -485
jmp -495
nop -115
acc +12
jmp -8
acc +31
acc -7
jmp -158
acc +44
acc +32
jmp +87
acc +1
acc +37
acc +44
jmp -86
acc +0
acc +17
acc -13
jmp -434
acc +37
jmp -342
acc +3
jmp +1
acc +29
jmp -242
acc +48
jmp -442
jmp -283
acc -19
acc +6
acc +20
acc +44
jmp -533
acc -15
nop -356
acc +18
jmp -408
acc -9
acc +17
acc +16
jmp -385
nop -130
jmp +1
acc +38
acc +39
jmp -324
jmp -141
acc +4
acc +3
acc -4
jmp -114
acc +2
jmp +1
acc +44
jmp -360
acc +43
acc +36
nop -177
nop -288
jmp -496
acc +45
acc +0
jmp -322
acc +13
jmp -511
acc -2
acc +36
jmp -460
acc +28
acc +28
jmp -455
acc -4
acc +38
jmp -145
jmp -163
jmp -331
nop -227
jmp -470
acc +35
nop -419
acc +39
acc +0
jmp -435
jmp +1
jmp -69
acc +20
acc +46
nop +2
jmp -239
acc -3
acc +12
acc +38
jmp -259
jmp -60
jmp -67
nop -542
jmp -397
acc +32
jmp -57
acc +30
nop -393
jmp -380
acc +16
acc -7
acc +0
acc +2
jmp +1";

            #endregion

            var split_string = input.Split("\r\n");
            List<(string, int, bool)> sortedList = new List<(string, int, bool)>();
            foreach (var line in split_string)
            {
                var two_items = line.Split(" ");
                var item1 = two_items[0];
                var item2 = int.Parse(two_items[1]);
                var item3 = false;
                sortedList.Add((item1, item2, item3));
            }
            // теперь список заполнен
            // теперь создаём список списков...
            List<List<(string, int, bool)>> listLists = new List<List<(string, int, bool)>>(); 
            // listLists.Add(sortedList);

            var workingList = sortedList.Select(x => x).ToList();
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i].Item1 == "nop")
                {
                    sortedList[i] = ("jmp", sortedList[i].Item2, sortedList[i].Item3);
                    listLists.Add(sortedList.ToList());
                    sortedList[i] = ("nop", sortedList[i].Item2, sortedList[i].Item3);
                    continue;
                }
                if (sortedList[i].Item1 == "jmp")
                {
                    sortedList[i] = ("nop", sortedList[i].Item2, sortedList[i].Item3);
                    listLists.Add(sortedList.ToList());
                    sortedList[i] = ("jmp", sortedList[i].Item2, sortedList[i].Item3);
                    continue;
                }
            }

            var accumulatorValue = 0;

            for (int i = 0; i < listLists.Count; i++)
            {
                for (int j = 0;; j++)
                {
                    start:
                    if (j == listLists[i].Count)
                    {
                        goto END;
                    }
                    if (j > listLists[i].Count || j < 0)
                    {
                        accumulatorValue = 0;
                        break;
                    }
                    if (listLists[i][j].Item3)
                    {
                        accumulatorValue = 0;
                        break;
                    }
                
                    if (listLists[i][j].Item1 == "nop")
                    {
                        listLists[i][j] = (listLists[i][j].Item1, listLists[i][j].Item2, true);
                        continue;
                    }
                    if (sortedList[j].Item1 == "acc")
                    {
                        accumulatorValue += listLists[i][j].Item2;
                        listLists[i][j] = (listLists[i][j].Item1, listLists[i][j].Item2, true);
                        continue;    
                    }
                    if (sortedList[j].Item1 == "jmp")
                    {
                        listLists[i][j] = (listLists[i][j].Item1, listLists[i][j].Item2, true);
                        j += listLists[i][j].Item2;
                        goto start;
                    }
                }
            }
            //

            END:
            
            Console.WriteLine(accumulatorValue);
        }
        
        private static void Task_9_1()
        {
            #region Real Data

            var input = $@"24
27
31
3
26
29
14
16
25
15
32
6
41
22
2
1
12
8
7
4
48
13
47
34
5
18
33
11
45
3
9
10
14
21
16
15
17
20
19
6
22
23
12
8
7
26
24
13
25
27
29
18
28
35
42
30
31
32
14
33
21
46
36
37
15
19
40
63
20
22
38
67
34
39
43
41
53
29
44
45
76
84
50
35
55
42
56
74
48
73
49
58
88
51
63
64
69
68
70
71
77
78
86
85
95
90
114
138
83
91
136
206
153
97
121
119
109
115
120
131
139
137
141
207
181
155
163
173
176
174
210
180
305
192
212
369
303
228
206
224
234
229
317
251
280
350
278
296
318
379
328
336
382
497
354
372
386
440
398
418
524
587
479
430
453
707
696
812
697
664
596
574
771
722
682
1175
690
758
1140
726
826
784
816
897
992
883
1066
909
1112
1179
1170
1296
1318
2088
1238
1380
1300
1995
1372
1466
1416
1448
1896
1510
1542
2112
1986
1725
1780
3008
1949
1975
3412
2282
2721
2408
2734
2828
2864
3018
3459
2672
2788
2820
2882
2958
3228
3322
4231
3267
4670
3505
3674
4957
4257
4683
4383
5522
4690
5129
5080
5406
5460
5492
5554
6247
8175
5608
10162
8195
9663
6495
6589
6772
7888
10278
8803
9763
8640
13803
9073
10928
10182
9770
10540
10486
10866
10952
11046
14411
14422
12103
17541
16981
18573
13084
18918
24897
14660
16528
17876
17443
17713
18843
19255
19559
19952
24908
20310
35824
21352
25363
24036
23149
31188
25187
26763
27744
29612
39565
38870
40023
32103
57441
38795
38814
35156
36968
38098
39207
39511
44501
41662
43459
64233
91977
47185
65558
48336
51950
54799
66614
90745
82970
71310
76912
67259
69071
74667
79760
72124
73254
86696
134559
86163
120357
85121
115595
109017
95521
146374
99135
100286
103135
106749
121413
140513
136330
138569
139383
141195
172859
142325
145378
151884
157245
171817
186982
198656
171284
237704
180642
202270
194656
195807
243648
240330
305405
209884
276843
274899
310386
275713
279764
302623
483245
287703
393312
297262
309129
367091
471520
412154
375298
455541
376449
382912
668211
470706
493069
450214
484783
585285
486727
977852
550612
555477
578336
590326
584965
596832
606391
673711
664353
1135059
957433
788603
942268
973281
1005691
759361
1021318
920920
934997
1378929
1476397
971510
1037339
1042204
1796700
1963894
1133813
1163301
1175291
1344326
1385435
1280102
1338064
1423714
1934652
2482088
1760113
1730871
2285793
1680281
1972336
2306355
2421133
1906507
2008849
2013714
3844847
2171152
2761778
3586788
2501365
2297114
2338592
3330221
2618166
2665537
3010973
5061092
3103995
3411152
3440394
3490984
4269450
4310828
3652617
3878843
4807720
3915356
3920221
4022563
6889816
4468266
8460337
6088153
6806858
4635706
4915280
4956758
6931378
6270783
8936320
6114968
6515147
6544389
6851546
7093011
7143601
7675180
7531460
7572838
7794199
8383622
7835577
7942784
8490829
11275124
9103972
11150853
9550986
9592464
9872038
11227541
11071726
12385751
12630115
14768191
13658748
13944557
13395935
13995147
15248018
14818781
15104298
19658746
20778527
18696436
16219199
15778361
23309610
23546133
18654958
18976010
20622712
22502153
26625262
20943764
31323497
36048062
25015866
28477529
27054683
27340492
27391082
28214716
29923079
39319148
30882659
31997560
39640200
34433319
34474797
61865879
37630968
39277670
45995450
39598722
39919774
45959630
43445917
64397876
47998447
54445765
53230582
59097375
62648035
68134490
60805738
76950116
58137795
69563279
62880219
77550742
73710989
68908116
106136242
72105765
76908638
121018014
79197444
106093952
79518496
83365691
145084606
96676499
115878617
120785830
107676347
111368377
151624261
118943533
136591208
127045911
134985984
127701074
154459380
131788335
141013881
142619105
148426612
156427134
149014403
281505291
158715940
180042190
189459643
239295604
191042038
228464834
236664447
300828020
219044724
226619880
298985723
255534741
245989444
373035355
290504275
259489409
268714955
272802216
280802738
283632986
291045717
394416056
305441537
307730343
371084228
338758130
599549062
380501681
573630236
410086762
501267050
527168722
519872744
528204364
517665597
373803594
586244275
574156492
532291625
540292147
578243753
1028435772
685943218
856423727
574678703
596487254
613171880
644199667
646488473
709842358
986975474
1101325214
906095219
1106448117
937255484
914095741
891469191
1145463505
1049957222
947960086
948482297
1152400245
1072583772
1106970328
1118535900
1299115098
1600147354
1510582995
1828724675
1221167176
1209659134
1323014238
2220425353
1594970770
2066495986
1820190960
1797564410
1805564932
1998439519
1851351225
1839429277
2355122639
2169649473
3405079861
2542930856
2021066069
2662983240
2179554100
2225506228
2328195034
3219606695
2821314530
2430826310
2532673372
3060596453
2804629904
4702322845
3392535180
3415161730
3617755370
3603129342
6150428742
3644994209
4167624311
3860495346
4009078750
4190715542
4200620169
5337303276
5865226357
5593269825
7921464859
4405060328
7032917100
5845988040
5252140840
4963499682
5491422763
6135802714
9136416972
6219791634
9692042932
7770753653
7018291072
7220884712
7248123551
7505489555
7654072959
11223632642
7869574096
8199794292
8391335711
8605680497
10556769507
12509713835
13364023478
10454922445
9368560010
11337410803
10215640522
10743563603
11099302396
11711214397
12355594348
13238082706
13440676346
14672364031
26678759052
14469008263
14726374267
18613137699
15159562514
19911008689
16069368388
22571234870
21724154358
16997016208
17974240507
19584200532
19823482455
20112123613
21314942918
20467862406
27406779191
23656316868
21842865999
22810516793
28113040377
25593677054
27909684609
28167050613
36515230030
29195382530
35653568920
34310574799
41753874688
31228930902
48279174226
48580902783
44534671151
65410191556
48377547015
37558441039
40052062938
77474556756
40579986019
50977567406
42310728405
44653382792
70220413014
47436543053
67744160932
53503361663
54789059584
56076735222
84732292565
60424313432
63505957329
65539505701
93030929807
68787371941
71280993840
77610503977
78138427058
79869169444
80632048957
82211823831
82890714424
155612983814
162342796542
117656956067
175242753638
105077696224
92089925845
107860856485
242986914570
108292421247
119042867364
150999195772
154171708264
330855737452
143677932759
129045463030
136820499541
140068365781
238503698238
148891497817
165102538255
162080993275
160501218401
162843872788
270203653027
201933581788
225949377314
197167622069
199950782330
224120563588
200382347092
211132793209
285711997358
227335288611
291889335818
616567734810
265865962571
283217171294
269113828811
272723395789
276888865322
493822917606
472137234815
324924866063
309392716218
432284646302
322582211676
323345091189
360011494857
397118404399
467799544359
400333129422
397549969161
411083575539
424502910680
411515140301
546002694133
493201251182
496449117422
608142037357
669404211075
595305607465
541837224600
549612261111
582116112007
600233956511
632737807407
648269957252
682593706533
631974927894
720132180837
645927302865
893999086583
1019657177658
1093907121755
868132673781
1328274218194
809065109462
822598715840
836018050981
904716391483
1078565229429
1315437788302
1038286342022
1131728373118
1091449485711
1123953336607
1214853919414
1149846217622
1264709818540
1232208884405
1264712735301
1454573643734
1536691319377
1940793482580
1529197290299
1454992412327
2151385550776
2353724130324
2397329964080
1631663825302
3808297774058
1645083160443
3851903607814
2116851571451
1943002733505
2578945748934
2129735827733
2215402822318
2223177858829
2877292044848
2273799554229
2364700137036
2719705147628
2793910025600
2496921619706
3996363962338
2984189702626
2991683731704
6843587339518
3086656237629
3606377963103
3276746985745
3761399653035
3574666558807
3588085893948
3761934731894
3774818988176
4708681576667
4836556719079
4072738561238
5855692734679
5374213664554
4438580681147
4496977413058
5550546539974
4638499691265
5481111322332
5216626767334
5290831645306
6661322796436
5975873434330
6070845940255
6363403223374
6674742131577
6693034200732
8103355376161
6851413544552
7162752452755
11601333133902
8483500564843
9243046054226
7847557549414
11266705079636
9077080372412
8569715974296
11406239274653
8935558094205
9135477104323
10614373125595
9855126458599
9929331336571
14352103871657
11654234868680
17307407326327
13526155676129
12046719374585
14174201316416
13038145354951
17646796346708
13544447745284
19098172512825
14014165997307
15010310002169
25440906396052
16331058114257
16417273523710
20731315241092
17505274068501
17705193078619
18071035198528
18790684552804
18864889430776
18990603562922
38038722567419
19784457795170
23455487012700
25084864729536
23700954243265
28554757747453
25572875050714
31109180553479
31828829907755
31191244091992
39455072393359
31719359075926
29024475999476
32515584070670
31341368116426
34036251192876
32748331637967
33922547592211
35210467147120
35576309267029
63939575729959
36861719751332"; 
            #endregion

            #region Test

                       var input2 = $@"35
           20
           15
           25
           47
           40
           62
           55
           65
           95
           102
           117
           150
           182
           127
           219
           299
           277
           309
           576"; 

            #endregion

            var numbers = input.Split("\r\n").Select(x => long.Parse(x)).ToList();
            List<long> shit_numbers = new List<long>();

            var max_count = numbers.Count;
            long answer;
            for (int min = 0, max = 24 ; max < max_count - 1; min++, max++)
            {
                var sumEqualFound = false;
                for (int i = min; i < max; i++)
                {
                    for (int j = i + 1; j <= max; j++)
                    {
                        if (numbers[i] + numbers[j] == numbers[max + 1])
                        {
                            sumEqualFound = true;
                            goto END_OF_CYCLE;
                        }
                    }
                }
                END_OF_CYCLE:
                if (!sumEqualFound)
                {
                    answer = numbers[max + 1];
                    goto END;
                }
            }
           
            END:
            Console.ReadLine();
        }
        
        private static void Task_9_2()
        {
            #region Real Data

            var input = $@"24
27
31
3
26
29
14
16
25
15
32
6
41
22
2
1
12
8
7
4
48
13
47
34
5
18
33
11
45
3
9
10
14
21
16
15
17
20
19
6
22
23
12
8
7
26
24
13
25
27
29
18
28
35
42
30
31
32
14
33
21
46
36
37
15
19
40
63
20
22
38
67
34
39
43
41
53
29
44
45
76
84
50
35
55
42
56
74
48
73
49
58
88
51
63
64
69
68
70
71
77
78
86
85
95
90
114
138
83
91
136
206
153
97
121
119
109
115
120
131
139
137
141
207
181
155
163
173
176
174
210
180
305
192
212
369
303
228
206
224
234
229
317
251
280
350
278
296
318
379
328
336
382
497
354
372
386
440
398
418
524
587
479
430
453
707
696
812
697
664
596
574
771
722
682
1175
690
758
1140
726
826
784
816
897
992
883
1066
909
1112
1179
1170
1296
1318
2088
1238
1380
1300
1995
1372
1466
1416
1448
1896
1510
1542
2112
1986
1725
1780
3008
1949
1975
3412
2282
2721
2408
2734
2828
2864
3018
3459
2672
2788
2820
2882
2958
3228
3322
4231
3267
4670
3505
3674
4957
4257
4683
4383
5522
4690
5129
5080
5406
5460
5492
5554
6247
8175
5608
10162
8195
9663
6495
6589
6772
7888
10278
8803
9763
8640
13803
9073
10928
10182
9770
10540
10486
10866
10952
11046
14411
14422
12103
17541
16981
18573
13084
18918
24897
14660
16528
17876
17443
17713
18843
19255
19559
19952
24908
20310
35824
21352
25363
24036
23149
31188
25187
26763
27744
29612
39565
38870
40023
32103
57441
38795
38814
35156
36968
38098
39207
39511
44501
41662
43459
64233
91977
47185
65558
48336
51950
54799
66614
90745
82970
71310
76912
67259
69071
74667
79760
72124
73254
86696
134559
86163
120357
85121
115595
109017
95521
146374
99135
100286
103135
106749
121413
140513
136330
138569
139383
141195
172859
142325
145378
151884
157245
171817
186982
198656
171284
237704
180642
202270
194656
195807
243648
240330
305405
209884
276843
274899
310386
275713
279764
302623
483245
287703
393312
297262
309129
367091
471520
412154
375298
455541
376449
382912
668211
470706
493069
450214
484783
585285
486727
977852
550612
555477
578336
590326
584965
596832
606391
673711
664353
1135059
957433
788603
942268
973281
1005691
759361
1021318
920920
934997
1378929
1476397
971510
1037339
1042204
1796700
1963894
1133813
1163301
1175291
1344326
1385435
1280102
1338064
1423714
1934652
2482088
1760113
1730871
2285793
1680281
1972336
2306355
2421133
1906507
2008849
2013714
3844847
2171152
2761778
3586788
2501365
2297114
2338592
3330221
2618166
2665537
3010973
5061092
3103995
3411152
3440394
3490984
4269450
4310828
3652617
3878843
4807720
3915356
3920221
4022563
6889816
4468266
8460337
6088153
6806858
4635706
4915280
4956758
6931378
6270783
8936320
6114968
6515147
6544389
6851546
7093011
7143601
7675180
7531460
7572838
7794199
8383622
7835577
7942784
8490829
11275124
9103972
11150853
9550986
9592464
9872038
11227541
11071726
12385751
12630115
14768191
13658748
13944557
13395935
13995147
15248018
14818781
15104298
19658746
20778527
18696436
16219199
15778361
23309610
23546133
18654958
18976010
20622712
22502153
26625262
20943764
31323497
36048062
25015866
28477529
27054683
27340492
27391082
28214716
29923079
39319148
30882659
31997560
39640200
34433319
34474797
61865879
37630968
39277670
45995450
39598722
39919774
45959630
43445917
64397876
47998447
54445765
53230582
59097375
62648035
68134490
60805738
76950116
58137795
69563279
62880219
77550742
73710989
68908116
106136242
72105765
76908638
121018014
79197444
106093952
79518496
83365691
145084606
96676499
115878617
120785830
107676347
111368377
151624261
118943533
136591208
127045911
134985984
127701074
154459380
131788335
141013881
142619105
148426612
156427134
149014403
281505291
158715940
180042190
189459643
239295604
191042038
228464834
236664447
300828020
219044724
226619880
298985723
255534741
245989444
373035355
290504275
259489409
268714955
272802216
280802738
283632986
291045717
394416056
305441537
307730343
371084228
338758130
599549062
380501681
573630236
410086762
501267050
527168722
519872744
528204364
517665597
373803594
586244275
574156492
532291625
540292147
578243753
1028435772
685943218
856423727
574678703
596487254
613171880
644199667
646488473
709842358
986975474
1101325214
906095219
1106448117
937255484
914095741
891469191
1145463505
1049957222
947960086
948482297
1152400245
1072583772
1106970328
1118535900
1299115098
1600147354
1510582995
1828724675
1221167176
1209659134
1323014238
2220425353
1594970770
2066495986
1820190960
1797564410
1805564932
1998439519
1851351225
1839429277
2355122639
2169649473
3405079861
2542930856
2021066069
2662983240
2179554100
2225506228
2328195034
3219606695
2821314530
2430826310
2532673372
3060596453
2804629904
4702322845
3392535180
3415161730
3617755370
3603129342
6150428742
3644994209
4167624311
3860495346
4009078750
4190715542
4200620169
5337303276
5865226357
5593269825
7921464859
4405060328
7032917100
5845988040
5252140840
4963499682
5491422763
6135802714
9136416972
6219791634
9692042932
7770753653
7018291072
7220884712
7248123551
7505489555
7654072959
11223632642
7869574096
8199794292
8391335711
8605680497
10556769507
12509713835
13364023478
10454922445
9368560010
11337410803
10215640522
10743563603
11099302396
11711214397
12355594348
13238082706
13440676346
14672364031
26678759052
14469008263
14726374267
18613137699
15159562514
19911008689
16069368388
22571234870
21724154358
16997016208
17974240507
19584200532
19823482455
20112123613
21314942918
20467862406
27406779191
23656316868
21842865999
22810516793
28113040377
25593677054
27909684609
28167050613
36515230030
29195382530
35653568920
34310574799
41753874688
31228930902
48279174226
48580902783
44534671151
65410191556
48377547015
37558441039
40052062938
77474556756
40579986019
50977567406
42310728405
44653382792
70220413014
47436543053
67744160932
53503361663
54789059584
56076735222
84732292565
60424313432
63505957329
65539505701
93030929807
68787371941
71280993840
77610503977
78138427058
79869169444
80632048957
82211823831
82890714424
155612983814
162342796542
117656956067
175242753638
105077696224
92089925845
107860856485
242986914570
108292421247
119042867364
150999195772
154171708264
330855737452
143677932759
129045463030
136820499541
140068365781
238503698238
148891497817
165102538255
162080993275
160501218401
162843872788
270203653027
201933581788
225949377314
197167622069
199950782330
224120563588
200382347092
211132793209
285711997358
227335288611
291889335818
616567734810
265865962571
283217171294
269113828811
272723395789
276888865322
493822917606
472137234815
324924866063
309392716218
432284646302
322582211676
323345091189
360011494857
397118404399
467799544359
400333129422
397549969161
411083575539
424502910680
411515140301
546002694133
493201251182
496449117422
608142037357
669404211075
595305607465
541837224600
549612261111
582116112007
600233956511
632737807407
648269957252
682593706533
631974927894
720132180837
645927302865
893999086583
1019657177658
1093907121755
868132673781
1328274218194
809065109462
822598715840
836018050981
904716391483
1078565229429
1315437788302
1038286342022
1131728373118
1091449485711
1123953336607
1214853919414
1149846217622
1264709818540
1232208884405
1264712735301
1454573643734
1536691319377
1940793482580
1529197290299
1454992412327
2151385550776
2353724130324
2397329964080
1631663825302
3808297774058
1645083160443
3851903607814
2116851571451
1943002733505
2578945748934
2129735827733
2215402822318
2223177858829
2877292044848
2273799554229
2364700137036
2719705147628
2793910025600
2496921619706
3996363962338
2984189702626
2991683731704
6843587339518
3086656237629
3606377963103
3276746985745
3761399653035
3574666558807
3588085893948
3761934731894
3774818988176
4708681576667
4836556719079
4072738561238
5855692734679
5374213664554
4438580681147
4496977413058
5550546539974
4638499691265
5481111322332
5216626767334
5290831645306
6661322796436
5975873434330
6070845940255
6363403223374
6674742131577
6693034200732
8103355376161
6851413544552
7162752452755
11601333133902
8483500564843
9243046054226
7847557549414
11266705079636
9077080372412
8569715974296
11406239274653
8935558094205
9135477104323
10614373125595
9855126458599
9929331336571
14352103871657
11654234868680
17307407326327
13526155676129
12046719374585
14174201316416
13038145354951
17646796346708
13544447745284
19098172512825
14014165997307
15010310002169
25440906396052
16331058114257
16417273523710
20731315241092
17505274068501
17705193078619
18071035198528
18790684552804
18864889430776
18990603562922
38038722567419
19784457795170
23455487012700
25084864729536
23700954243265
28554757747453
25572875050714
31109180553479
31828829907755
31191244091992
39455072393359
31719359075926
29024475999476
32515584070670
31341368116426
34036251192876
32748331637967
33922547592211
35210467147120
35576309267029
63939575729959
36861719751332"; 
            #endregion

            #region Test

                       var input2 = $@"35
20
15
25
47
40
62
55
65
95
102
117
150
182
127
219
299
277
309
576"; 

            #endregion

            var numbers = input.Split("\r\n").Select(x => long.Parse(x)).ToList();
            List<long> shit_numbers = new List<long>();

            var max_count = numbers.Count;
            long answer = 0;
            for (int min = 0, max = 24 ; max < max_count - 1; min++, max++)
            {
                var sumEqualFound = false;
                for (int i = min; i < max; i++)
                {
                    for (int j = i + 1; j <= max; j++)
                    {
                        if (numbers[i] + numbers[j] == numbers[max + 1])
                        {
                            sumEqualFound = true;
                            goto END_OF_CYCLE;
                        }
                    }
                }
                END_OF_CYCLE:
                if (!sumEqualFound)
                {
                    answer = numbers[max + 1];
                    goto END;
                }
            }
            
            END:
            long answer2;
            
            List<long> numbersForSum = new List<long>();
            for (int i = 0; i < max_count - 2; i++)
            {
                for (int j = i; j < max_count - 1; j++)
                {
                    numbersForSum.Add(numbers[j]);
                    if (numbersForSum.Sum() > answer)
                    {
                        numbersForSum.Clear();
                        continue;
                    }

                    if (numbersForSum.Sum() == answer && numbersForSum.Count > 1)
                    {
                        answer2 = numbersForSum.Max() + numbersForSum.Min();
                        goto END2;
                    }
                }
            }
            
            END2:
            
            Console.ReadLine();
        }
    }
}