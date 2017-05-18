using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Element
    {
        private NhanVien data;
	    private Element nextPtr;
	    private Element prePtr;
	
	    public Element() {
		    this.nextPtr = null;
		    this.prePtr = null;
	    }

        public Element(NhanVien d)
        {
		    this.data = d;
		    this.nextPtr = null;
		    this.prePtr = null;
	    }

        public NhanVien getData()
        {
		    return data;
	    }

        public void setData(NhanVien data)
        {
		    this.data = data;
	    }

	    public Element getNextPtr() {
		    return nextPtr;
	    }

	    public void setNextPtr(Element nextPtr) {
		    this.nextPtr = nextPtr;
	    }

	    public Element getPrePtr() {
		    return prePtr;
	    }

	    public void setPrePtr(Element prePtr) {
		    this.prePtr = prePtr;
	    }
	
	    public override String ToString() {
		    return data.ToString();
	    }
    }
}
