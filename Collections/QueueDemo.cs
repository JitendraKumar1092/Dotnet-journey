class QueueDemo{
    public void queueDemo(){
        Queue<int> q = new Queue<int>();
       
         q.Enqueue(9);
          q.Enqueue(0);
        q.Enqueue(1);
        foreach(int i in q){
            Console.WriteLine("{0}"  , q.Peek());
        }
      

    }
}