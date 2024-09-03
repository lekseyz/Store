using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class ItemReview
    {
        public ItemReview(int id, int itemId, int score, int userId, string? text)
        {
            Id = id;
            ItemId = itemId;
            Score = score;
            UserId = userId;
            Text = text ?? String.Empty;
        }

        public int Id { get; }
        public int ItemId { get; }
        public int Score { get; }
        public int UserId { get; }
        public string Text { get; } = String.Empty;
    }
}
