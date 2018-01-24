// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Video card
    /// </summary>
    public partial class VideoCard
    {
        /// <summary>
        /// Initializes a new instance of the VideoCard class.
        /// </summary>
        public VideoCard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoCard class.
        /// </summary>
        /// <param name="title">Title of this card</param>
        /// <param name="subtitle">Subtitle of this card</param>
        /// <param name="text">Text of this card</param>
        /// <param name="image">Thumbnail placeholder</param>
        /// <param name="media">Media URLs for this card</param>
        /// <param name="buttons">Actions on this card</param>
        /// <param name="shareable">This content may be shared with others
        /// (default:true)</param>
        /// <param name="autoloop">Should the client loop playback at end of
        /// content (default:true)</param>
        /// <param name="autostart">Should the client automatically start
        /// playback of media in this card (default:true)</param>
        /// <param name="aspect">Aspect ratio of thumbnail/media placeholder,
        /// allowed values are "16:9" and "4:3"</param>
        /// <param name="value">Supplementary parameter for this card</param>
        public VideoCard(string title = default(string), string subtitle = default(string), string text = default(string), ThumbnailUrl image = default(ThumbnailUrl), IList<MediaUrl> media = default(IList<MediaUrl>), IList<CardAction> buttons = default(IList<CardAction>), bool? shareable = default(bool?), bool? autoloop = default(bool?), bool? autostart = default(bool?), string aspect = default(string), object value = default(object))
        {
            Title = title;
            Subtitle = subtitle;
            Text = text;
            Image = image;
            Media = media;
            Buttons = buttons;
            Shareable = shareable;
            Autoloop = autoloop;
            Autostart = autostart;
            Aspect = aspect;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets title of this card
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets subtitle of this card
        /// </summary>
        [JsonProperty(PropertyName = "subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or sets text of this card
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets thumbnail placeholder
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ThumbnailUrl Image { get; set; }

        /// <summary>
        /// Gets or sets media URLs for this card
        /// </summary>
        [JsonProperty(PropertyName = "media")]
        public IList<MediaUrl> Media { get; set; }

        /// <summary>
        /// Gets or sets actions on this card
        /// </summary>
        [JsonProperty(PropertyName = "buttons")]
        public IList<CardAction> Buttons { get; set; }

        /// <summary>
        /// Gets or sets this content may be shared with others (default:true)
        /// </summary>
        [JsonProperty(PropertyName = "shareable")]
        public bool? Shareable { get; set; }

        /// <summary>
        /// Gets or sets should the client loop playback at end of content
        /// (default:true)
        /// </summary>
        [JsonProperty(PropertyName = "autoloop")]
        public bool? Autoloop { get; set; }

        /// <summary>
        /// Gets or sets should the client automatically start playback of
        /// media in this card (default:true)
        /// </summary>
        [JsonProperty(PropertyName = "autostart")]
        public bool? Autostart { get; set; }

        /// <summary>
        /// Gets or sets aspect ratio of thumbnail/media placeholder, allowed
        /// values are "16:9" and "4:3"
        /// </summary>
        [JsonProperty(PropertyName = "aspect")]
        public string Aspect { get; set; }

        /// <summary>
        /// Gets or sets supplementary parameter for this card
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Image != null)
            {
                Image.Validate();
            }
            if (Media != null)
            {
                foreach (var element in Media)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
