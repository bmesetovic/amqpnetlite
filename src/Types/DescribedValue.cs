﻿//  ------------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation
//  All rights reserved. 
//  
//  Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this 
//  file except in compliance with the License. You may obtain a copy of the License at 
//  http://www.apache.org/licenses/LICENSE-2.0  
//  
//  THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
//  EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR 
//  CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR 
//  NON-INFRINGEMENT. 
// 
//  See the Apache Version 2.0 License for specific language governing permissions and 
//  limitations under the License.
//  ------------------------------------------------------------------------------------

namespace Amqp.Types
{
    using System;

    public class DescribedValue : Described
    {
        object value;

        public DescribedValue(Descriptor descriptor)
            : base(descriptor)
        {
        }

        public object Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public override void DecodeValue(ByteBuffer buffer)
        {
            this.value = Encoder.ReadObject(buffer);
        }

        protected override void EncodeValue(ByteBuffer buffer)
        {
            Encoder.WriteObject(buffer, this.value);
        }

        public override string ToString()
        {
            return this.value == null ? null : this.value.ToString();
        }
    }
}
