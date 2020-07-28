using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.Canvas.WebGL
{
    public class WebGL2Context : WebGLContext
    {
        #region Constants

        private const string CONTEXT_NAME = "WebGL2";
        private const string VERTEX_ATTRIB_DIVISOR = "vertexAttribDivisor";

        #endregion

        internal WebGL2Context(BECanvasComponent reference, WebGLContextAttributes attributes = null, string contextName = CONTEXT_NAME) : base(reference, attributes, contextName)
        {

        }

        #region Methods

        public async Task VertexAttribDivisor(uint index, uint divisor) => await this.BatchCallAsync(VERTEX_ATTRIB_DIVISOR, isMethodCall: true, index, divisor);

        #endregion
    }
}
