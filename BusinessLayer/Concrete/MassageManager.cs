using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MassageManager : IMessageService
    {
        IMessageService _messageService;

        public MassageManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void TAdd(Message t)
        {
            _messageService.TAdd(t);
        }

        public void TDelete(Message t)
        {
            _messageService.TDelete(t);
        }

        public Message TGetByID(int id)
        {
            _messageService.TGetByID(id);
            return _messageService.TGetByID(id);
        }

        public List<Message> TGetList()
        {
            _messageService.TGetList();
            return _messageService.TGetList();
        }

        public void TUpdate(Message t)
        {
            _messageService.TUpdate(t);
        }
    }
}
