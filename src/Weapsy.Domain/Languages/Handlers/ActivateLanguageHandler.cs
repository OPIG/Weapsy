using FluentValidation;
using System;
using System.Collections.Generic;
using Weapsy.Infrastructure.Domain;
using Weapsy.Domain.Languages.Commands;

namespace Weapsy.Domain.Languages.Handlers
{
    public class ActivateLanguageHandler : ICommandHandler<ActivateLanguage>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IValidator<ActivateLanguage> _validator;

        public ActivateLanguageHandler(ILanguageRepository languageRepository, IValidator<ActivateLanguage> validator)
        {
            _languageRepository = languageRepository;
            _validator = validator;
        }

        public IEnumerable<IEvent> Handle(ActivateLanguage command)
        {
            var language = _languageRepository.GetById(command.SiteId, command.Id);

            if (language == null)
                throw new Exception("Language not found.");

            language.Activate(command, _validator);

            _languageRepository.Update(language);

            return language.Events;
        }
    }
}
