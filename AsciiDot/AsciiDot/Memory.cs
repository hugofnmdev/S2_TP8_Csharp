using System;
using System.Collections.Generic;

namespace AsciiDot
{
    public enum Environment
    {
        Default,
        Output,
        SingleQuote,
        DoubleQuote,
        Affectation
    }
    
    public class Memory
    {
        /**
         * <summary>The stored value of the dot.</summary>
         */
        public double Value;
        
        /**
         * <summary>In Witch environment the dot is.</summary>
         * <see cref="Environment"/>
         */
        public Environment CurrentEnvironment;
        
        /**
         * <summary>Queue of visited tokens.</summary>
         */
        public List<Token.Token> Queue;

        /**
         * <summary>
         * Constructor of Memory.
         * </summary>
         */
        public Memory()
        {
            // TODO
            throw new NotImplementedException("TODO");
        }

        public Memory(Environment currentEnvironment)
        {
            CurrentEnvironment = currentEnvironment;
        }

        /**
         * <summary>
         * Copy constructor of Memory.
         * </summary>
         * 
         * <param name="memory">The memory to clone.</param>
         */
        private Memory(Memory memory)
        {

        }
        
        

        public Memory Clone() => new Memory(this);

        public void Enqueue(Token.Token token) => Queue.Add(token);
        
        /**
         * <summary>
         * Try to flush the queue and apply queued actions: Assignment or Display or nothing.
         * </summary>
         */
        public void Flush()
        {
            // TODO
            throw new NotImplementedException("TODO");
        }

        /**
         * <summary>Apply assignment action</summary>
         * 
         * <param name="str">The input string beginning with '#'.</param>
         */
        public void Assignment(string str)
        {
            // TODO
            throw new NotImplementedException("TODO");
        }

        /**
         * <summary>Apply display action</summary>
         * 
         * <param name="str">The input string beginning with '$'.</param>
         */
        public void Display(string str)
        {
            // TODO
            throw new NotImplementedException("TODO");
        }
    }
}