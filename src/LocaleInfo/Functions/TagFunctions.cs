using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReaderIO;

namespace Functions
{
    class IndexHeaderFunctions
    {
        int tagtableoff = 0;
        int imptagsoff = 0;
        short impclassindex = 0;
        int impclasstableindex = 0;
        int impclassaddress = 0;
        int impclassoffset = 0;

        /// <summary>
        /// Finds the Tag Table with the Index Header Offset
        /// </summary>
        /// <param name="_path">The file that is being read.</param>
        /// <param name="__indexheaderoffset">Value of the Index Header Offset.</param>
        /// <param name="_tagmask">The file's tagmask.</param>
        public int FindTagTable(string _path, int _indexheaderoffset, int _tagmask)
        {
            Reader r = new Reader(_path);

            r.Position = _indexheaderoffset + 0xC;
            int tagtableadd = r.ReadInt32();

            return tagtableoff = (tagtableadd - _tagmask);

        }

        /// <summary>
        /// Finds the offset of a tag in the "Important Tag Class" table.
        /// </summary>
        /// <param name="_indexheaderoffset">Value of the Index Header Offset.</param>
        /// <param name="_path">The file that is being read.</param>
        /// <param name="importanttagsindex">The index of the important tag class table to be found.</param>
        /// <param name="_tagmask">The file's tagmask.</param>
        // Indexes:
        // Halo 3 Beta: draw = 0, ugh! = 1, zone = 2, scnr = 3, matg = 4
        // Halo 3/ODST: draw = 0, play = 1, ugh! = 2, zone = 3, scnr = 4, matg = 5
        // Reach Beta - Halo 4: draw = 0, gpix = 1, play = 2, ugh! = 3, zone = 4, scnr = 5, matg = 6
        // Halo 4 Patch Maps - draw = 0, gpix = 1, play = 2, ugh! = 3, zone = 4, patg = 5
        public int ImportantTagOffsetFinder(int _indexheaderoffset, string _path, int importanttagsindex, int _tagmask)
        {
            FindTagTable(_path, _indexheaderoffset, _tagmask);

            int imptagspos = (0x8 * importanttagsindex) + 0x6;

            Reader r = new Reader(_path);

            r.Position = _indexheaderoffset + 0x14;
            int imptagsadd = r.ReadInt32();

            imptagsoff = (imptagsadd - _tagmask);

            r.Position = imptagsoff + imptagspos;
            impclassindex = r.ReadInt16();

            impclasstableindex = (impclassindex * 0x8);

            r.Position = tagtableoff + impclasstableindex + 0x4;
            impclassaddress = r.ReadInt32();

            return impclassoffset = (impclassaddress - _tagmask);
        }
    }
}
