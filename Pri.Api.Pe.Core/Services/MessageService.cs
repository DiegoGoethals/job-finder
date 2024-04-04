﻿using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<ResultModel<Message>> CreateAsync(string content, Guid senderId, Guid receiverId)
        {
            var message = new Message
            {
                Id = Guid.NewGuid(),
                Content = content,
                SenderId = senderId,
                ReceiverId = receiverId,
                Created = DateTime.UtcNow
            };
            if (await _messageRepository.AddAsync(message))
            {
                return new ResultModel<Message>
                {
                    IsSucces = true,
                    Value = message
                };
            }
            return new ResultModel<Message>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<Message>> UpdateAsync(Guid id, string content)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            if (message == null)
            {
                return new ResultModel<Message>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Message not found!"
                    }
                };
            }
            message.Content = content;
            if (await _messageRepository.UpdateAsync(message))
            {
                return new ResultModel<Message>
                {
                    IsSucces = true,
                    Value = message
                };
            }
            return new ResultModel<Message>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<Message>> DeleteAsync(Guid id)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            if (message == null)
            {
                return new ResultModel<Message>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Message not found!"
                    }
                };
            }
            if (await _messageRepository.DeleteAsync(message))
            {
                return new ResultModel<Message>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Message>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<IEnumerable<Message>>> GetConversationAsync(Guid id1, Guid id2)
        {
            var messages = await _messageRepository.GetConversationAsync(id1, id2);
            if (messages.Any())
            {
                return new ResultModel<IEnumerable<Message>>
                {
                    IsSucces = true,
                    Value = messages
                };
            }
            return new ResultModel<IEnumerable<Message>>
            {
                IsSucces = false,
                Errors = new List<string>
                    {
                        "Conversation not found!"
                    }
            };
        }
    }
}
