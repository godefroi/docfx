// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.EntityModel.Swagger.Internal
{
    internal abstract class SwaggerObjectBase
    {
        public abstract SwaggerObjectType ObjectType { get; }
        public bool ReferencesResolved { get; set; }
    }
}
