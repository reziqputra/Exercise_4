namespace Exercise_4
{
    class node
    {
        public int info;
        public node next;
        int reziq = 62;
        int top;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

    }
}