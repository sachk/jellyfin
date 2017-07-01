// This code is derived from jcifs smb client library <jcifs at samba dot org>
// Ported by J. Arturo <webmaster at komodosoft dot net>
//  
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
namespace SharpCifs.Smb
{
    internal class SmbComFindClose2 : ServerMessageBlock
    {
        private int _sid;

        internal SmbComFindClose2(int sid)
        {
            this._sid = sid;
            Command = SmbComFindClose2;
        }

        internal override int WriteParameterWordsWireFormat(byte[] dst, int dstIndex)
        {
            WriteInt2(_sid, dst, dstIndex);
            return 2;
        }

        internal override int WriteBytesWireFormat(byte[] dst, int dstIndex)
        {
            return 0;
        }

        internal override int ReadParameterWordsWireFormat(byte[] buffer, int bufferIndex)
        {
            return 0;
        }

        internal override int ReadBytesWireFormat(byte[] buffer, int bufferIndex)
        {
            return 0;
        }

        public override string ToString()
        {
            return "SmbComFindClose2["
                        + base.ToString()
                        + ",sid=" + _sid + "]";
        }
    }
}