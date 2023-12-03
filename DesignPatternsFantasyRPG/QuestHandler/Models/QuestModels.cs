using DesignPatternsFantasyRPG.CharacterCreator.Models;

namespace DesignPatternsFantasyRPG.QuestHandler.Models
{
    // Observer interface
    public interface IQuestObserver
    {
        void Update(Quest quest);
    }

    // Observable interface
    public interface IQuestObservable
    {
        void Subscribe(IQuestObserver observer);
        void Unsubscribe(IQuestObserver observer);
        void NotifyObservers();
    }

    // Concrete Observable 
    public class Quest : IQuestObservable
    {
        private List<IQuestObserver> observers = new List<IQuestObserver>();
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public Character Opponent { get; private set; }

        public Quest(string name, string description, Character opponent)
        {
            Name = name;
            Description = description;
            IsCompleted = false;
            Opponent = opponent;
        }

        public void CompleteQuest()
        {
            IsCompleted = true;
            NotifyObservers();
        }

        public void Subscribe(IQuestObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IQuestObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
