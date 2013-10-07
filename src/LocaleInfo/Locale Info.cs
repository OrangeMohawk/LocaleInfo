using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaderIO;
using Functions;
using BadBuild;

namespace ThirdGenLocales
{
    public partial class LocaleInfo : Form
    {
        Reader r = null;

        int indexheaderoffset = 0;
        int tagmask = 0;

        string path = "";
        string o = "0x";

        string halo3betabuild = "09699.07.05.01.1534.delta";

        string halo3build = "11855.07.08.20.2317.halo3_ship";
        string halo3reviewbuild = "11856.07.08.20.2332.release";
        string halo3epsilonbuild = "11729.07.08.10.0021.main";
        string halo3mythicbuild = "12065.08.08.26.0819.halo3_ship";

        string halo3odstbuild = "13895.09.04.27.2201.atlas_relea";

        string reachprebetabuild = "09449.10.03.25.1545.omaha_beta";
        string reachbetabuild = "09730.10.04.09.1309.omaha_delta";
        string reachbuild = "00095.11.04.09.1509.demo";
        string reachdemobuild = "11860.10.07.24.0147.omaha_relea";

        string halo4build = "20810.12.09.22.1647.main";
        string halo4tu2build = "21122.12.11.21.0101.main";
        string halo4tu3build = "21165.12.12.12.0112.main";
        string halo4tu4build = "21339.13.02.05.0117.main";
        string halo4tu5build = "21391.13.03.13.1711.main";
        string halo4tu6build = "21401.13.04.23.1849.main";
        string halo4tu7build = "21501.13.08.06.2311.main";

        public void GetH3BLocales(string _path, int _globalsoffset)
        {
            Functions.LocaleLanguageInfo LLI = new LocaleLanguageInfo();
            int[] h3blocales = LLI.GetH3BLoc(_path, _globalsoffset);

            englishcountText.Paste(h3blocales[0].ToString());
            englishdataText.Paste(o + h3blocales[1].ToString("X"));
            englishdatasizeText.Paste(o + h3blocales[2].ToString("X"));
            englishindexText.Paste(o + h3blocales[3].ToString("X"));
            japanesecountText.Paste(h3blocales[4].ToString());
            japanesedataText.Paste(o + h3blocales[5].ToString("X"));
            japanesedatasizeText.Paste(o + h3blocales[6].ToString("X"));
            japaneseindexText.Paste(o + h3blocales[7].ToString("X"));
            germancountText.Paste(h3blocales[8].ToString());
            germandataText.Paste(o + h3blocales[9].ToString("X"));
            germandatasizeText.Paste(o + h3blocales[10].ToString("X"));
            germanindexText.Paste(o + h3blocales[11].ToString("X"));
            frenchcountText.Paste(h3blocales[12].ToString());
            frenchdataText.Paste(o + h3blocales[13].ToString("X"));
            frenchdatasizeText.Paste(o + h3blocales[14].ToString("X"));
            frenchindexText.Paste(o + h3blocales[15].ToString("X"));
            spanishcountText.Paste(h3blocales[16].ToString());
            spanishdataText.Paste(o + h3blocales[17].ToString("X"));
            spanishdatasizeText.Paste(o + h3blocales[18].ToString("X"));
            spanishindexText.Paste(o + h3blocales[19].ToString("X"));
            mexicancountText.Paste(h3blocales[20].ToString());
            mexicandataText.Paste(o + h3blocales[21].ToString("X"));
            mexicandatasizeText.Paste(o + h3blocales[22].ToString("X"));
            mexicanindexText.Paste(o + h3blocales[23].ToString("X"));
            italiancountText.Paste(h3blocales[24].ToString());
            italiandataText.Paste(o + h3blocales[25].ToString("X"));
            italiandatasizeText.Paste(o + h3blocales[26].ToString("X"));
            italianindexText.Paste(o + h3blocales[27].ToString("X"));
            koreancountText.Paste(h3blocales[28].ToString());
            koreandataText.Paste(o + h3blocales[29].ToString("X"));
            koreandatasizeText.Paste(o + h3blocales[30].ToString("X"));
            koreanindexText.Paste(o + h3blocales[31].ToString("X"));
            chintradcountText.Paste(h3blocales[32].ToString());
            chintraddataText.Paste(o + h3blocales[33].ToString("X"));
            chintraddatasizeText.Paste(o + h3blocales[34].ToString("X"));
            chintradindexText.Paste(o + h3blocales[35].ToString("X"));
            chinsimpcountText.Paste(h3blocales[36].ToString());
            chinsimpdataText.Paste(o + h3blocales[37].ToString("X"));
            chinsimpdatasizeText.Paste(o + h3blocales[38].ToString("X"));
            chinsimpindexText.Paste(o + h3blocales[39].ToString("X"));
            portuguesecountText.Paste(h3blocales[40].ToString());
            portuguesedataText.Paste(o + h3blocales[41].ToString("X"));
            portuguesedatasizeText.Paste(o + h3blocales[42].ToString("X"));
            portugueseindexText.Paste(o + h3blocales[43].ToString("X"));
            polishcountText.Paste(h3blocales[44].ToString());
            polishdataText.Paste(o + h3blocales[45].ToString("X"));
            polishdatasizeText.Paste(o + h3blocales[46].ToString("X"));
            polishindexText.Paste(o + h3blocales[47].ToString("X"));
        }

        public void HideH4Values()
        {
            blanklabel1.Hide();
            h4line1.Hide();
            h4line2.Hide();
            h4line3.Hide();
            h4line4.Hide();
            h4line5.Hide();
            h4line6.Hide();
            h4langDani.Hide();
            h4langDutc.Hide();
            h4langFinn.Hide();
            h4langNorw.Hide();
            h4langRuss.Hide();
            h4ind1.Hide();
            h4ind2.Hide();
            h4ind3.Hide();
            h4ind4.Hide();
            h4ind5.Hide();
            h4dat1.Hide();
            h4dat2.Hide();
            h4dat3.Hide();
            h4dat4.Hide();
            h4dat5.Hide();
            h4cnt1.Hide();
            h4cnt2.Hide();
            h4cnt3.Hide();
            h4cnt4.Hide();
            h4cnt5.Hide();
            h4dsz1.Hide();
            h4dsz2.Hide();
            h4dsz3.Hide();
            h4dsz4.Hide();
            h4dsz5.Hide();
            russiancountText.Hide();
            russiandataText.Hide();
            russiandatasizeText.Hide();
            russianindexText.Hide();
            danishcountText.Hide();
            danishdataText.Hide();
            danishdatasizeText.Hide();
            danishindexText.Hide();
            finnishcountText.Hide();
            finnishdataText.Hide();
            finnishdatasizeText.Hide();
            finnishindexText.Hide();
            dutchcountText.Hide();
            dutchdataText.Hide();
            dutchdatasizeText.Hide();
            dutchindexText.Hide();
            norwegiancountText.Hide();
            norwegiandataText.Hide();
            norwegiandatasizeText.Hide();
            norwegianindexText.Hide();
        }

        public void ShowH4Values()
        {
            blanklabel1.Show();
            h4line1.Show();
            h4line2.Show();
            h4line3.Show();
            h4line4.Show();
            h4line5.Show();
            h4line6.Show();
            h4langDani.Show();
            h4langDutc.Show();
            h4langFinn.Show();
            h4langNorw.Show();
            h4langRuss.Show();
            h4ind1.Show();
            h4ind2.Show();
            h4ind3.Show();
            h4ind4.Show();
            h4ind5.Show();
            h4dat1.Show();
            h4dat2.Show();
            h4dat3.Show();
            h4dat4.Show();
            h4dat5.Show();
            h4cnt1.Show();
            h4cnt2.Show();
            h4cnt3.Show();
            h4cnt4.Show();
            h4cnt5.Show();
            h4dsz1.Show();
            h4dsz2.Show();
            h4dsz3.Show();
            h4dsz4.Show();
            h4dsz5.Show();
            russiancountText.Show();
            russiandataText.Show();
            russiandatasizeText.Show();
            russianindexText.Show();
            danishcountText.Show();
            danishdataText.Show();
            danishdatasizeText.Show();
            danishindexText.Show();
            finnishcountText.Show();
            finnishdataText.Show();
            finnishdatasizeText.Show();
            finnishindexText.Show();
            dutchcountText.Show();
            dutchdataText.Show();
            dutchdatasizeText.Show();
            dutchindexText.Show();
            norwegiancountText.Show();
            norwegiandataText.Show();
            norwegiandatasizeText.Show();
            norwegianindexText.Show();
        }

        public void GetLocales(string _path, int _globalsoffset, int _globalsenglishcountoffset)
        {
            Functions.LocaleLanguageInfo LLI = new LocaleLanguageInfo();
            int[] locales = LLI.GetLoc(_path, _globalsoffset, _globalsenglishcountoffset);

            englishcountText.Paste(locales[0].ToString());
            englishdataText.Paste(o + locales[1].ToString("X"));
            englishdatasizeText.Paste(o + locales[2].ToString("X"));
            englishindexText.Paste(o + locales[3].ToString("X"));
            japanesecountText.Paste(locales[4].ToString());
            japanesedataText.Paste(o + locales[5].ToString("X"));
            japanesedatasizeText.Paste(o + locales[6].ToString("X"));
            japaneseindexText.Paste(o + locales[7].ToString("X"));
            germancountText.Paste(locales[8].ToString());
            germandataText.Paste(o + locales[9].ToString("X"));
            germandatasizeText.Paste(o + locales[10].ToString("X"));
            germanindexText.Paste(o + locales[11].ToString("X"));
            frenchcountText.Paste(locales[12].ToString());
            frenchdataText.Paste(o + locales[13].ToString("X"));
            frenchdatasizeText.Paste(o + locales[14].ToString("X"));
            frenchindexText.Paste(o + locales[15].ToString("X"));
            spanishcountText.Paste(locales[16].ToString());
            spanishdataText.Paste(o + locales[17].ToString("X"));
            spanishdatasizeText.Paste(o + locales[18].ToString("X"));
            spanishindexText.Paste(o + locales[19].ToString("X"));
            mexicancountText.Paste(locales[20].ToString());
            mexicandataText.Paste(o + locales[21].ToString("X"));
            mexicandatasizeText.Paste(o + locales[22].ToString("X"));
            mexicanindexText.Paste(o + locales[23].ToString("X"));
            italiancountText.Paste(locales[24].ToString());
            italiandataText.Paste(o + locales[25].ToString("X"));
            italiandatasizeText.Paste(o + locales[26].ToString("X"));
            italianindexText.Paste(o + locales[27].ToString("X"));
            koreancountText.Paste(locales[28].ToString());
            koreandataText.Paste(o + locales[29].ToString("X"));
            koreandatasizeText.Paste(o + locales[30].ToString("X"));
            koreanindexText.Paste(o + locales[31].ToString("X"));
            chintradcountText.Paste(locales[32].ToString());
            chintraddataText.Paste(o + locales[33].ToString("X"));
            chintraddatasizeText.Paste(o + locales[34].ToString("X"));
            chintradindexText.Paste(o + locales[35].ToString("X"));
            chinsimpcountText.Paste(locales[36].ToString());
            chinsimpdataText.Paste(o + locales[37].ToString("X"));
            chinsimpdatasizeText.Paste(o + locales[38].ToString("X"));
            chinsimpindexText.Paste(o + locales[39].ToString("X"));
            portuguesecountText.Paste(locales[40].ToString());
            portuguesedataText.Paste(o + locales[41].ToString("X"));
            portuguesedatasizeText.Paste(o + locales[42].ToString("X"));
            portugueseindexText.Paste(o + locales[43].ToString("X"));
            polishcountText.Paste(locales[44].ToString());
            polishdataText.Paste(o + locales[45].ToString("X"));
            polishdatasizeText.Paste(o + locales[46].ToString("X"));
            polishindexText.Paste(o + locales[47].ToString("X"));
        }

        public void GetH4Locales(string _path, int _globalsoffset, int _globalsenglishcountoffset)
        {
            Functions.LocaleLanguageInfo LLI = new LocaleLanguageInfo();
            int[] locales = LLI.GetH4Loc(_path, _globalsoffset, _globalsenglishcountoffset);

            englishcountText.Paste(locales[0].ToString());
            englishdataText.Paste(o + locales[1].ToString("X"));
            englishdatasizeText.Paste(o + locales[2].ToString("X"));
            englishindexText.Paste(o + locales[3].ToString("X"));
            japanesecountText.Paste(locales[4].ToString());
            japanesedataText.Paste(o + locales[5].ToString("X"));
            japanesedatasizeText.Paste(o + locales[6].ToString("X"));
            japaneseindexText.Paste(o + locales[7].ToString("X"));
            germancountText.Paste(locales[8].ToString());
            germandataText.Paste(o + locales[9].ToString("X"));
            germandatasizeText.Paste(o + locales[10].ToString("X"));
            germanindexText.Paste(o + locales[11].ToString("X"));
            frenchcountText.Paste(locales[12].ToString());
            frenchdataText.Paste(o + locales[13].ToString("X"));
            frenchdatasizeText.Paste(o + locales[14].ToString("X"));
            frenchindexText.Paste(o + locales[15].ToString("X"));
            spanishcountText.Paste(locales[16].ToString());
            spanishdataText.Paste(o + locales[17].ToString("X"));
            spanishdatasizeText.Paste(o + locales[18].ToString("X"));
            spanishindexText.Paste(o + locales[19].ToString("X"));
            mexicancountText.Paste(locales[20].ToString());
            mexicandataText.Paste(o + locales[21].ToString("X"));
            mexicandatasizeText.Paste(o + locales[22].ToString("X"));
            mexicanindexText.Paste(o + locales[23].ToString("X"));
            italiancountText.Paste(locales[24].ToString());
            italiandataText.Paste(o + locales[25].ToString("X"));
            italiandatasizeText.Paste(o + locales[26].ToString("X"));
            italianindexText.Paste(o + locales[27].ToString("X"));
            koreancountText.Paste(locales[28].ToString());
            koreandataText.Paste(o + locales[29].ToString("X"));
            koreandatasizeText.Paste(o + locales[30].ToString("X"));
            koreanindexText.Paste(o + locales[31].ToString("X"));
            chintradcountText.Paste(locales[32].ToString());
            chintraddataText.Paste(o + locales[33].ToString("X"));
            chintraddatasizeText.Paste(o + locales[34].ToString("X"));
            chintradindexText.Paste(o + locales[35].ToString("X"));
            chinsimpcountText.Paste(locales[36].ToString());
            chinsimpdataText.Paste(o + locales[37].ToString("X"));
            chinsimpdatasizeText.Paste(o + locales[38].ToString("X"));
            chinsimpindexText.Paste(o + locales[39].ToString("X"));
            portuguesecountText.Paste(locales[40].ToString());
            portuguesedataText.Paste(o + locales[41].ToString("X"));
            portuguesedatasizeText.Paste(o + locales[42].ToString("X"));
            portugueseindexText.Paste(o + locales[43].ToString("X"));
            polishcountText.Paste(locales[44].ToString());
            polishdataText.Paste(o + locales[45].ToString("X"));
            polishdatasizeText.Paste(o + locales[46].ToString("X"));
            polishindexText.Paste(o + locales[47].ToString("X"));
            russiancountText.Paste(locales[48].ToString());
            russiandataText.Paste(o + locales[49].ToString("X"));
            russiandatasizeText.Paste(o + locales[50].ToString("X"));
            russianindexText.Paste(o + locales[51].ToString("X"));
            danishcountText.Paste(locales[52].ToString());
            danishdataText.Paste(o + locales[53].ToString("X"));
            danishdatasizeText.Paste(o + locales[54].ToString("X"));
            danishindexText.Paste(o + locales[55].ToString("X"));
            finnishcountText.Paste(locales[56].ToString());
            finnishdataText.Paste(o + locales[57].ToString("X"));
            finnishdatasizeText.Paste(o + locales[58].ToString("X"));
            finnishindexText.Paste(o + locales[59].ToString("X"));
            dutchcountText.Paste(locales[60].ToString());
            dutchdataText.Paste(o + locales[61].ToString("X"));
            dutchdatasizeText.Paste(o + locales[62].ToString("X"));
            dutchindexText.Paste(o + locales[63].ToString("X"));
            norwegiancountText.Paste(locales[64].ToString());
            norwegiandataText.Paste(o + locales[65].ToString("X"));
            norwegiandatasizeText.Paste(o + locales[66].ToString("X"));
            norwegianindexText.Paste(o + locales[67].ToString("X"));
        }

        public void ClearBoxes()
        {
            directoryBox.Clear();
            buildText.Clear();
            gameText.Clear();
            internalText.Clear();
            englishcountText.Clear();
            englishdatasizeText.Clear();
            englishdataText.Clear();
            englishindexText.Clear();
            japanesecountText.Clear();
            japanesedatasizeText.Clear();
            japanesedataText.Clear();
            japaneseindexText.Clear();
            germancountText.Clear();
            germandatasizeText.Clear();
            germandataText.Clear();
            germanindexText.Clear();
            frenchcountText.Clear();
            frenchdatasizeText.Clear();
            frenchdataText.Clear();
            frenchindexText.Clear();
            spanishcountText.Clear();
            spanishdatasizeText.Clear();
            spanishdataText.Clear();
            spanishindexText.Clear();
            mexicancountText.Clear();
            mexicandatasizeText.Clear();
            mexicandataText.Clear();
            mexicanindexText.Clear();
            italiancountText.Clear();
            italiandatasizeText.Clear();
            italiandataText.Clear();
            italianindexText.Clear();
            koreancountText.Clear();
            koreandatasizeText.Clear();
            koreandataText.Clear();
            koreanindexText.Clear();
            chintradcountText.Clear();
            chintraddatasizeText.Clear();
            chintraddataText.Clear();
            chintradindexText.Clear();
            chinsimpcountText.Clear();
            chinsimpdatasizeText.Clear();
            chinsimpdataText.Clear();
            chinsimpindexText.Clear();
            portuguesecountText.Clear();
            portuguesedatasizeText.Clear();
            portuguesedataText.Clear();
            portugueseindexText.Clear();
            polishcountText.Clear();
            polishdatasizeText.Clear();
            polishdataText.Clear();
            polishindexText.Clear();
            russiancountText.Clear();
            russiandatasizeText.Clear();
            russiandataText.Clear();
            russianindexText.Clear();
            danishcountText.Clear();
            danishdatasizeText.Clear();
            danishdataText.Clear();
            danishindexText.Clear();
            finnishcountText.Clear();
            finnishdatasizeText.Clear();
            finnishdataText.Clear();
            finnishindexText.Clear();
            dutchcountText.Clear();
            dutchdatasizeText.Clear();
            dutchdataText.Clear();
            dutchindexText.Clear();
            norwegiancountText.Clear();
            norwegiandatasizeText.Clear();
            norwegiandataText.Clear();
            norwegianindexText.Clear();
        }

        public LocaleInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NoLocalesDialog()
        {
            MessageBox.Show("No locale info could be found.", "Error: No Locales");
        }

        public void GetLocales()
        {
            ClearBoxes();

            directoryBox.Paste(path);

            r = new Reader(path);
            r.Position = 0x0;
            string headmagic = r.ReadString(0x4);

            if (headmagic == "head")
            {
                r.Position = 0x10;
                int indexheaderaddress = r.ReadInt32();

                r.Position = 0x11C;
                string build = r.ReadString(0x20);

                buildText.Paste(build);

                r.Position = 0x13C;
                short type = r.ReadInt16();
                bool ingamemap = (type != 0x3 && type != 0x4);

                bool halo3beta = (buildText.Text == halo3betabuild);

                bool halo3 = (buildText.Text == halo3build);
                bool halo3review = (buildText.Text == halo3reviewbuild);
                bool halo3epsilon = (buildText.Text == halo3epsilonbuild);
                bool halo3mythic = (buildText.Text == halo3mythicbuild);

                bool halo3odst = (buildText.Text == halo3odstbuild);

                bool reachprebeta = (buildText.Text == reachprebetabuild);
                bool reachbeta = (buildText.Text == reachbetabuild);
                bool reachbetas = (reachprebeta || reachbeta);

                bool reach = (buildText.Text == reachbuild);
                bool reachdemo = (buildText.Text == reachdemobuild);
                bool reachbuilds = (reach || reachdemo);

                bool halo4tu0 = (buildText.Text == halo4build);
                bool halo4tu2 = (buildText.Text == halo4tu2build);
                bool halo4tu3 = (buildText.Text == halo4tu3build);
                bool halo4tu4 = (buildText.Text == halo4tu4build);
                bool halo4tu5 = (buildText.Text == halo4tu5build);
                bool halo4tu6 = (buildText.Text == halo4tu6build);
                bool halo4tu7 = (buildText.Text == halo4tu7build);

                bool allhalo3noODST = (halo3 || halo3mythic || halo3review || halo3epsilon);
                bool allhalo3builds = (allhalo3noODST || halo3odst);
                bool allreachbuilds = (reachbetas || reachbuilds);
                bool halo4 = (halo4tu0 || halo4tu2 || halo4tu3 || halo4tu4 || halo4tu5 || halo4tu6 || halo4tu7);

                bool thirdgennoH3B = (allhalo3builds || allreachbuilds || halo4);

                bool thirdgen = (thirdgennoH3B || halo3beta);

                IndexHeaderFunctions IHF = new IndexHeaderFunctions();

                if (!thirdgen)
                {
                    UnrecognizedBuild UB = new UnrecognizedBuild(buildText.Text);
                    UB.ShowDialog();
                }

                    if (!halo4)
                    {
                        HideH4Values();
                    }

                    if (halo3beta)
                    {
                        gameText.Paste("Halo 3 Beta");

                        r.Position = 0x194;
                        string Internal = r.ReadString(0x20);
                        internalText.Paste(Internal);

                        r.Position = 0x14;
                        int metaoff = r.ReadInt32();

                        r.Position = 0x2F0;
                        int virtualbase = r.ReadInt32();

                        tagmask = (virtualbase - metaoff);

                        indexheaderoffset = (indexheaderaddress - tagmask);

                        int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 4, tagmask);

                        if (ingamemap)
                        {
                            GetH3BLocales(path, globalsoffset);
                        }

                        if (!ingamemap)
                        {
                            NoLocalesDialog();
                        }
                    }

                    if (allhalo3builds || allreachbuilds)
                    {
                        if (halo3)
                            gameText.Paste("Halo 3");
                        if (halo3review)
                            gameText.Paste("Halo 3 Review");
                        if (halo3epsilon)
                            gameText.Paste("Halo 3 Epsilon");
                        if (halo3mythic)
                            gameText.Paste("Halo 3 Mythic");
                        if (halo3odst)
                            gameText.Paste("Halo 3: ODST");
                        if (reachprebeta)
                            gameText.Paste("Halo: Reach Pre-Beta");
                        if (reachbeta)
                            gameText.Paste("Halo: Reach Beta");
                        if (reach)
                            gameText.Paste("Halo: Reach Demo");
                        if (reachdemo)
                            gameText.Paste("Halo: Reach");

                        r.Position = 0x18C;
                        string Internal = r.ReadString(0x20);
                        internalText.Paste(Internal);

                        r.Position = 0x2E8;
                        int virtualbase = r.ReadInt32();

                        r.Position = 0x470;
                        int assetdata = r.ReadInt32();
                        
                        r.Position = 0x478;
                        int localemagic = r.ReadInt32();

                        r.Position = 0x488;
                        int assetdatasize = r.ReadInt32();

                        int metaoff = (assetdata + assetdatasize);

                        tagmask = (virtualbase - metaoff);

                        indexheaderoffset = (indexheaderaddress - tagmask);

                        if (ingamemap)
                        {
                            if (allhalo3builds)
                            {
                                int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 5, tagmask);

                                if (allhalo3noODST)
                                {
                                    GetLocales(path, globalsoffset, 0x1C4);
                                }
                                if (halo3odst)
                                {
                                    GetLocales(path, globalsoffset, 0x1FC);
                                }
                            }
                            if (allreachbuilds)
                            {
                                int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 6, tagmask);

                                if (reachbetas)
                                {
                                    GetLocales(path, globalsoffset, 0x240);
                                }
                                if (reachbuilds)
                                {
                                    GetLocales(path, globalsoffset, 0x290);
                                }
                            }
                        }
                        if (!ingamemap)
                        {
                            NoLocalesDialog();
                        }
                    }
                    if (halo4)
                    {
                        ShowH4Values();

                        gameText.Paste("Halo 4");

                        r.Position = 0x18C;
                        string Internal = r.ReadString(0x20);
                        internalText.Paste(Internal);

                        r.Position = 0x2F8;
                        int virtualbase = r.ReadInt32();

                        r.Position = 0x480;
                        int assetdata = r.ReadInt32();

                        r.Position = 0x488;
                        int localemagic = r.ReadInt32();

                        r.Position = 0x498;
                        int assetdatasize = r.ReadInt32();

                        if (ingamemap)
                        {
                            if (localemagic != 0)
                            {
                                int metaOffset = (assetdata + assetdatasize);

                                tagmask = (virtualbase - metaOffset);

                                indexheaderoffset = (indexheaderaddress - virtualbase + metaOffset);

                                r.Position = indexheaderoffset + 0x10;
                                int imptagcount = r.ReadInt32();

                                if (ingamemap)
                                {
                                    // regular maps
                                    if (imptagcount == 0x7)
                                    {
                                        int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 6, tagmask);

                                        GetH4Locales(path, globalsoffset, 0x2BC);
                                    }

                                    // patchmaps
                                    if (imptagcount == 0x6)
                                    {
                                        int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 5, tagmask);

                                        GetH4Locales(path, globalsoffset, 0x8);
                                    }
                                }
                            }

                            // maps without raw
                            if (localemagic == 0)
                            {
                                r.Position = 0x14;
                                int metaOffset = r.ReadInt32();

                                tagmask = (virtualbase - metaOffset);

                                indexheaderoffset = (indexheaderaddress - virtualbase + metaOffset);

                                int globalsoffset = IHF.ImportantTagOffsetFinder(indexheaderoffset, path, 6, tagmask);

                                GetH4Locales(path, globalsoffset, 0x2BC);
                            }
                        }

                        if (!ingamemap)
                        {
                            NoLocalesDialog();
                        }

                    }

            }

            if (headmagic == "daeh")
            {
                MessageBox.Show("Only Third Generation map files are supported.", "Error: Not Third Gen");
            }

            if (headmagic != "head" && headmagic != "daeh")
            {
                MessageBox.Show("Unrecognized Header Magic! Only Third Generation map files are supported.", "Error: Unrecognized Header Magic");
            }
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "3rd Gen Blam .map Files (*.map)|*.map";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = open.FileName;
                GetLocales();
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            path = files[files.Length - 1];
            GetLocales();
        }
    }
}
