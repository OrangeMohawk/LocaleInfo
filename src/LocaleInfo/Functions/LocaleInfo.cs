using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReaderIO;

namespace Functions
{
    class LocaleLanguageInfo
    {
        public int[] GetH3BLoc(string _path, int _globalsoffset)
        {
            Reader r = new Reader(_path);

            r.Position = _globalsoffset + 0x1E8;
            int englishcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x1EC;
            int englishdatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x1F0;
            int englishindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x1F4;
            int englishdata = r.ReadInt32();

            r.Position = _globalsoffset + 0x204;
            int japanesecount = r.ReadInt32();

            r.Position = _globalsoffset + 0x208;
            int japanesedatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x20C;
            int japaneseindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x210;
            int japanesedata = r.ReadInt32();

            r.Position = _globalsoffset + 0x220;
            int germancount = r.ReadInt32();

            r.Position = _globalsoffset + 0x224;
            int germandatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x228;
            int germanindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x22C;
            int germandata = r.ReadInt32();

            r.Position = _globalsoffset + 0x23C;
            int frenchcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x240;
            int frenchdatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x244;
            int frenchindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x248;
            int frenchdata = r.ReadInt32();

            r.Position = _globalsoffset + 0x258;
            int spanishcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x25C;
            int spanishdatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x260;
            int spanishindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x264;
            int spanishdata = r.ReadInt32();

            r.Position = _globalsoffset + 0x274;
            int mexicancount = r.ReadInt32();

            r.Position = _globalsoffset + 0x278;
            int mexicandatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x27C;
            int mexicanindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x280;
            int mexicandata = r.ReadInt32();

            r.Position = _globalsoffset + 0x290;
            int italiancount = r.ReadInt32();

            r.Position = _globalsoffset + 0x294;
            int italiandatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x298;
            int italianindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x29C;
            int italiandata = r.ReadInt32();

            r.Position = _globalsoffset + 0x2AC;
            int koreancount = r.ReadInt32();

            r.Position = _globalsoffset + 0x2B0;
            int koreandatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x2B4;
            int koreanindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x2B8;
            int koreandata = r.ReadInt32();

            r.Position = _globalsoffset + 0x2C8;
            int chintradcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x2CC;
            int chintraddatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x2D0;
            int chintradindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x2D4;
            int chintraddata = r.ReadInt32();

            r.Position = _globalsoffset + 0x2E4;
            int chinsimpcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x2E8;
            int chinsimpdatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x2EC;
            int chinsimpindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x2F0;
            int chinsimpdata = r.ReadInt32();

            r.Position = _globalsoffset + 0x300;
            int portuguesecount = r.ReadInt32();

            r.Position = _globalsoffset + 0x304;
            int portuguesedatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x308;
            int portugueseindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x30C;
            int portuguesedata = r.ReadInt32();

            r.Position = _globalsoffset + 0x31C;
            int polishcount = r.ReadInt32();

            r.Position = _globalsoffset + 0x320;
            int polishdatasize = r.ReadInt32();

            r.Position = _globalsoffset + 0x324;
            int polishindex = r.ReadInt32();

            r.Position = _globalsoffset + 0x328;
            int polishdata = r.ReadInt32();

            int[] localeinfo = {
                         englishcount,
                         englishdata,
                         englishdatasize,
                         englishindex,
                         japanesecount,
                         japanesedata,
                         japanesedatasize,
                         japaneseindex,
                         germancount,
                         germandata,
                         germandatasize,
                         germanindex,
                         frenchcount,
                         frenchdata,
                         frenchdatasize,
                         frenchindex,
                         spanishcount,
                         spanishdata,
                         spanishdatasize,
                         spanishindex,
                         mexicancount,
                         mexicandata,
                         mexicandatasize,
                         mexicanindex,
                         italiancount,
                         italiandata,
                         italiandatasize,
                         italianindex,
                         koreancount,
                         koreandata,
                         koreandatasize,
                         koreanindex,
                         chintradcount,
                         chintraddata,
                         chintraddatasize,
                         chintradindex,
                         chinsimpcount,
                         chinsimpdata,
                         chinsimpdatasize,
                         chinsimpindex,
                         portuguesecount,
                         portuguesedata,
                         portuguesedatasize,
                         portugueseindex,
                         polishcount,
                         polishdata,
                         polishdatasize,
                         polishindex,
                         };
            return localeinfo;
        }

        public int[] GetH3Locales(string _path, int _globalsoffset)
        {
            int[] h3locales = GetLoc(_path, _globalsoffset, 0x1C4);
            return h3locales;
        }

        public int[] GetODSTLocales(string _path, int _globalsoffset)
        {
            int[] ODSTlocales = GetLoc(_path, _globalsoffset, 0x1FC);
            return ODSTlocales;
        }

        public int[] GetReachBetaLocales(string _path, int _globalsoffset)
        {
            int[] ReachBetalocales = GetLoc(_path, _globalsoffset, 0x240);
            return ReachBetalocales;
        }

        public int[] GetReachLocales(string _path, int _globalsoffset)
        {
            int[] Reachlocales = GetLoc(_path, _globalsoffset, 0x290);
            return Reachlocales;
        }

        public int[] GetLoc(string _path, int _globalsoffset, int globalsenglishcountoffset)
        {
            Reader r = new Reader(_path);

            r.Position = 0x478;
            int localemagic = r.ReadInt32();

            int englishcountoffset = (_globalsoffset + globalsenglishcountoffset);

            r.Position = englishcountoffset;
            int englishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x4;
            int englishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x8;
            int _englishindex = r.ReadInt32();
            int englishindex = _englishindex + localemagic;

            r.Position = englishcountoffset + 0xC;
            int _englishdata = r.ReadInt32();
            int englishdata = _englishdata + localemagic;

            r.Position = englishcountoffset + 0x44;
            int japanesecount = r.ReadInt32();

            r.Position = englishcountoffset + 0x48;
            int japanesedatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x4C;
            int _japaneseindex = r.ReadInt32();
            int japaneseindex = _japaneseindex + localemagic;

            r.Position = englishcountoffset + 0x50;
            int _japanesedata = r.ReadInt32();
            int japanesedata = _japanesedata + localemagic;

            r.Position = englishcountoffset + 0x88;
            int germancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x8C;
            int germandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x90;
            int _germanindex = r.ReadInt32();
            int germanindex = _germanindex + localemagic;

            r.Position = englishcountoffset + 0x94;
            int _germandata = r.ReadInt32();
            int germandata = _germandata + localemagic;

            r.Position = englishcountoffset + 0xCC;
            int frenchcount = r.ReadInt32();

            r.Position = englishcountoffset + 0xD0;
            int frenchdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0xD4;
            int _frenchindex = r.ReadInt32();
            int frenchindex = _frenchindex + localemagic;

            r.Position = englishcountoffset + 0xD8;
            int _frenchdata = r.ReadInt32();
            int frenchdata = _frenchdata + localemagic;

            r.Position = englishcountoffset + 0x110;
            int spanishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x114;
            int spanishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x118;
            int _spanishindex = r.ReadInt32();
            int spanishindex = _spanishindex + localemagic;

            r.Position = englishcountoffset + 0x11C;
            int _spanishdata = r.ReadInt32();
            int spanishdata = _spanishdata + localemagic;

            r.Position = englishcountoffset + 0x154;
            int mexicancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x158;
            int mexicandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x15C;
            int _mexicanindex = r.ReadInt32();
            int mexicanindex = _mexicanindex + localemagic;

            r.Position = englishcountoffset + 0x160;
            int _mexicandata = r.ReadInt32();
            int mexicandata = _mexicandata + localemagic;

            r.Position = englishcountoffset + 0x198;
            int italiancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x19C;
            int italiandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x1A0;
            int _italianindex = r.ReadInt32();
            int italianindex = _italianindex + localemagic;

            r.Position = englishcountoffset + 0x1A4;
            int _italiandata = r.ReadInt32();
            int italiandata = _italiandata + localemagic;

            r.Position = englishcountoffset + 0x1DC;
            int koreancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x1E0;
            int koreandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x1E4;
            int _koreanindex = r.ReadInt32();
            int koreanindex = _koreanindex + localemagic;

            r.Position = englishcountoffset + 0x1E8;
            int _koreandata = r.ReadInt32();
            int koreandata = _koreandata + localemagic;

            r.Position = englishcountoffset + 0x220;
            int chintradcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x224;
            int chintraddatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x228;
            int _chintradindex = r.ReadInt32();
            int chintradindex = _chintradindex + localemagic;

            r.Position = englishcountoffset + 0x22C;
            int _chintraddata = r.ReadInt32();
            int chintraddata = _chintraddata + localemagic;

            r.Position = englishcountoffset + 0x264;
            int chinsimpcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x268;
            int chinsimpdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x26C;
            int _chinsimpindex = r.ReadInt32();
            int chinsimpindex = _chinsimpindex + localemagic;

            r.Position = englishcountoffset + 0x270;
            int _chinsimpdata = r.ReadInt32();
            int chinsimpdata = _chinsimpdata + localemagic;

            r.Position = englishcountoffset + 0x2A8;
            int portuguesecount = r.ReadInt32();

            r.Position = englishcountoffset + 0x2AC;
            int portuguesedatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x2B0;
            int _portugueseindex = r.ReadInt32();
            int portugueseindex = _portugueseindex + localemagic;

            r.Position = englishcountoffset + 0x2B4;
            int _portuguesedata = r.ReadInt32();
            int portuguesedata = _portuguesedata + localemagic;

            r.Position = englishcountoffset + 0x2EC;
            int polishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x2F0;
            int polishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x2F4;
            int _polishindex = r.ReadInt32();
            int polishindex = _polishindex + localemagic;

            r.Position = englishcountoffset + 0x2F8;
            int _polishdata = r.ReadInt32();
            int polishdata = _polishdata + localemagic;

            int[] localeinfo = {
                         englishcount,
                         englishdata,
                         englishdatasize,
                         englishindex,
                         japanesecount,
                         japanesedata,
                         japanesedatasize,
                         japaneseindex,
                         germancount,
                         germandata,
                         germandatasize,
                         germanindex,
                         frenchcount,
                         frenchdata,
                         frenchdatasize,
                         frenchindex,
                         spanishcount,
                         spanishdata,
                         spanishdatasize,
                         spanishindex,
                         mexicancount,
                         mexicandata,
                         mexicandatasize,
                         mexicanindex,
                         italiancount,
                         italiandata,
                         italiandatasize,
                         italianindex,
                         koreancount,
                         koreandata,
                         koreandatasize,
                         koreanindex,
                         chintradcount,
                         chintraddata,
                         chintraddatasize,
                         chintradindex,
                         chinsimpcount,
                         chinsimpdata,
                         chinsimpdatasize,
                         chinsimpindex,
                         portuguesecount,
                         portuguesedata,
                         portuguesedatasize,
                         portugueseindex,
                         polishcount,
                         polishdata,
                         polishdatasize,
                         polishindex,
                         };
            return localeinfo;
        }

        public int[] GetHalo4MATGLocales(string _path, int _globalsoffset)
        {
            int[] h4locales = GetH4Loc(_path, _globalsoffset, 0x2BC);
            return h4locales;
        }

        public int[] GetHalo4PATGLocales(string _path, int _globalsoffset)
        {
            int[] h4patglocales = GetH4Loc(_path, _globalsoffset, 0x2BC);
            return h4patglocales;
        }

        public int[] GetH4Loc(string _path, int _globalsoffset, int globalsenglishcountoffset)
        {
            Reader r = new Reader(_path);

            r.Position = 0x488;
            int localemagic = r.ReadInt32();

            int englishcountoffset = (_globalsoffset + globalsenglishcountoffset);

            r.Position = englishcountoffset;
            int englishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x4;
            int englishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x8;
            int _englishindex = r.ReadInt32();
            int englishindex = _englishindex + localemagic;

            r.Position = englishcountoffset + 0xC;
            int _englishdata = r.ReadInt32();
            int englishdata = _englishdata + localemagic;

            r.Position = englishcountoffset + 0x44;
            int japanesecount = r.ReadInt32();

            r.Position = englishcountoffset + 0x48;
            int japanesedatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x4C;
            int _japaneseindex = r.ReadInt32();
            int japaneseindex = _japaneseindex + localemagic;

            r.Position = englishcountoffset + 0x50;
            int _japanesedata = r.ReadInt32();
            int japanesedata = _japanesedata + localemagic;

            r.Position = englishcountoffset + 0x88;
            int germancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x8C;
            int germandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x90;
            int _germanindex = r.ReadInt32();
            int germanindex = _germanindex + localemagic;

            r.Position = englishcountoffset + 0x94;
            int _germandata = r.ReadInt32();
            int germandata = _germandata + localemagic;

            r.Position = englishcountoffset + 0xCC;
            int frenchcount = r.ReadInt32();

            r.Position = englishcountoffset + 0xD0;
            int frenchdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0xD4;
            int _frenchindex = r.ReadInt32();
            int frenchindex = _frenchindex + localemagic;

            r.Position = englishcountoffset + 0xD8;
            int _frenchdata = r.ReadInt32();
            int frenchdata = _frenchdata + localemagic;

            r.Position = englishcountoffset + 0x110;
            int spanishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x114;
            int spanishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x118;
            int _spanishindex = r.ReadInt32();
            int spanishindex = _spanishindex + localemagic;

            r.Position = englishcountoffset + 0x11C;
            int _spanishdata = r.ReadInt32();
            int spanishdata = _spanishdata + localemagic;

            r.Position = englishcountoffset + 0x154;
            int mexicancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x158;
            int mexicandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x15C;
            int _mexicanindex = r.ReadInt32();
            int mexicanindex = _mexicanindex + localemagic;

            r.Position = englishcountoffset + 0x160;
            int _mexicandata = r.ReadInt32();
            int mexicandata = _mexicandata + localemagic;

            r.Position = englishcountoffset + 0x198;
            int italiancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x19C;
            int italiandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x1A0;
            int _italianindex = r.ReadInt32();
            int italianindex = _italianindex + localemagic;

            r.Position = englishcountoffset + 0x1A4;
            int _italiandata = r.ReadInt32();
            int italiandata = _italiandata + localemagic;

            r.Position = englishcountoffset + 0x1DC;
            int koreancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x1E0;
            int koreandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x1E4;
            int _koreanindex = r.ReadInt32();
            int koreanindex = _koreanindex + localemagic;

            r.Position = englishcountoffset + 0x1E8;
            int _koreandata = r.ReadInt32();
            int koreandata = _koreandata + localemagic;

            r.Position = englishcountoffset + 0x220;
            int chintradcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x224;
            int chintraddatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x228;
            int _chintradindex = r.ReadInt32();
            int chintradindex = _chintradindex + localemagic;

            r.Position = englishcountoffset + 0x22C;
            int _chintraddata = r.ReadInt32();
            int chintraddata = _chintraddata + localemagic;

            r.Position = englishcountoffset + 0x264;
            int chinsimpcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x268;
            int chinsimpdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x26C;
            int _chinsimpindex = r.ReadInt32();
            int chinsimpindex = _chinsimpindex + localemagic;

            r.Position = englishcountoffset + 0x270;
            int _chinsimpdata = r.ReadInt32();
            int chinsimpdata = _chinsimpdata + localemagic;

            r.Position = englishcountoffset + 0x2A8;
            int portuguesecount = r.ReadInt32();

            r.Position = englishcountoffset + 0x2AC;
            int portuguesedatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x2B0;
            int _portugueseindex = r.ReadInt32();
            int portugueseindex = _portugueseindex + localemagic;

            r.Position = englishcountoffset + 0x2B4;
            int _portuguesedata = r.ReadInt32();
            int portuguesedata = _portuguesedata + localemagic;

            r.Position = englishcountoffset + 0x2EC;
            int polishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x2F0;
            int polishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x2F4;
            int _polishindex = r.ReadInt32();
            int polishindex = _polishindex + localemagic;

            r.Position = englishcountoffset + 0x2F8;
            int _polishdata = r.ReadInt32();
            int polishdata = _polishdata + localemagic;

            r.Position = englishcountoffset + 0x330;
            int russiancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x334;
            int russiandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x338;
            int _russianindex = r.ReadInt32();
            int russianindex = _russianindex + localemagic;

            r.Position = englishcountoffset + 0x33C;
            int _russiandata = r.ReadInt32();
            int russiandata = _russiandata + localemagic;

            r.Position = englishcountoffset + 0x374;
            int danishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x378;
            int danishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x37C;
            int _danishindex = r.ReadInt32();
            int danishindex = _danishindex + localemagic;

            r.Position = englishcountoffset + 0x380;
            int _danishdata = r.ReadInt32();
            int danishdata = _danishdata + localemagic;

            r.Position = englishcountoffset + 0x3B8;
            int finnishcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x3BC;
            int finnishdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x3C0;
            int _finnishindex = r.ReadInt32();
            int finnishindex = _finnishindex + localemagic;

            r.Position = englishcountoffset + 0x3C4;
            int _finnishdata = r.ReadInt32();
            int finnishdata = _finnishdata + localemagic;

            r.Position = englishcountoffset + 0x3FC;
            int dutchcount = r.ReadInt32();

            r.Position = englishcountoffset + 0x400;
            int dutchdatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x404;
            int _dutchindex = r.ReadInt32();
            int dutchindex = _dutchindex + localemagic;

            r.Position = englishcountoffset + 0x408;
            int _dutchdata = r.ReadInt32();
            int dutchdata = _dutchdata + localemagic;

            r.Position = englishcountoffset + 0x440;
            int norwegiancount = r.ReadInt32();

            r.Position = englishcountoffset + 0x444;
            int norwegiandatasize = r.ReadInt32();

            r.Position = englishcountoffset + 0x448;
            int _norwegianindex = r.ReadInt32();
            int norwegianindex = _norwegianindex + localemagic;

            r.Position = englishcountoffset + 0x44C;
            int _norwegiandata = r.ReadInt32();
            int norwegiandata = _norwegiandata + localemagic;

            int[] localeinfo = {
                         englishcount,
                         englishdata,
                         englishdatasize,
                         englishindex,
                         japanesecount,
                         japanesedata,
                         japanesedatasize,
                         japaneseindex,
                         germancount,
                         germandata,
                         germandatasize,
                         germanindex,
                         frenchcount,
                         frenchdata,
                         frenchdatasize,
                         frenchindex,
                         spanishcount,
                         spanishdata,
                         spanishdatasize,
                         spanishindex,
                         mexicancount,
                         mexicandata,
                         mexicandatasize,
                         mexicanindex,
                         italiancount,
                         italiandata,
                         italiandatasize,
                         italianindex,
                         koreancount,
                         koreandata,
                         koreandatasize,
                         koreanindex,
                         chintradcount,
                         chintraddata,
                         chintraddatasize,
                         chintradindex,
                         chinsimpcount,
                         chinsimpdata,
                         chinsimpdatasize,
                         chinsimpindex,
                         portuguesecount,
                         portuguesedata,
                         portuguesedatasize,
                         portugueseindex,
                         polishcount,
                         polishdata,
                         polishdatasize,
                         polishindex,
                         russiancount,
                         russiandata,
                         russiandatasize,
                         russianindex,
                         danishcount,
                         danishdata,
                         danishdatasize,
                         danishindex,
                         finnishcount,
                         finnishdata,
                         finnishdatasize,
                         finnishindex,
                         dutchcount,
                         dutchdata,
                         dutchdatasize,
                         dutchindex,
                         norwegiancount,
                         norwegiandata,
                         norwegiandatasize,
                         norwegianindex,
                         };
            return localeinfo;
        }
    }
}
