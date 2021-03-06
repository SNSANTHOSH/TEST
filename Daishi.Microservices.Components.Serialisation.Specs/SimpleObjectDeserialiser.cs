﻿#region Includes

using System;

#endregion

namespace Daishi.Microservices.Components.Serialisation.Specs {
    internal class SimpleObjectDeserialiser : Deserialiser<SimpleObject> {
        public SimpleObjectDeserialiser(StandardJsonNameValueCollection parser) : base(parser) {}

        public override SimpleObject Deserialise(bool mergeArrayValues = false) {
            var properties = jsonNameValueCollection.Parse(mergeArrayValues);

            return new SimpleObject {
                Name = properties.Get("simpleObject.name"),
                Count = Convert.ToInt32(properties.Get("simpleObject.count"))
            };
        }
    }
}