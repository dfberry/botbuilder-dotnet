﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;
using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.Number;
using static Microsoft.Bot.Builder.Prompts.PromptValidatorEx;

namespace Microsoft.Bot.Builder.Prompts
{
    public class RangeResult
    {
        public float Start { get; set; }

        public float End { get; set; }

        public string Text { get; set; }
    }

    /// <summary>
    /// RangeResult recognizes range expressions like "between 2 and 4" -> Start =2 End =4
    /// </summary>
    public class RangePrompt<T> : BasePrompt<RangeResult>
    {
        private IModel _model;

        public RangePrompt(string culture, PromptValidator<RangeResult> validator = null)
            :base(validator)
        {
            _model = NumberRecognizer.Instance.GetNumberRangeModel(culture);
        }

        protected RangePrompt(IModel model, PromptValidator<RangeResult> validator = null)
            :base(validator)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
        }

        public override async Task<RangeResult> Recognize(IBotContext context)
        {
            BotAssert.ContextNotNull(context);
            BotAssert.ActivityNotNull(context.Request);
            if (context.Request.Type != ActivityTypes.Message)
                throw new InvalidOperationException("No Message to Recognize");

            IMessageActivity message = context.Request.AsMessageActivity();
            var results = _model.Parse(message.Text);
            if (results.Any())
            {
                var result = results.First();
                if (result.TypeName == "numberrange")
                {
                    string[] values = result.Resolution["value"].ToString().Trim('(', ')').Split(',');
                    RangeResult rangeResult = new RangeResult()
                    {
                        Text = result.Text
                    };
                    if (float.TryParse(values[0], out float startValue) && float.TryParse(values[1], out float endValue))
                    {
                        rangeResult.Start = startValue;
                        rangeResult.End = endValue;
                    }
                    if (await Validate(context, rangeResult))
                        return rangeResult;
                }
            }
            return null;
        }

    }
}
