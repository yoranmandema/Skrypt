﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skrypt.Engine;
using Skrypt.Interpreter.Compiler;

namespace Skrypt.Interpreter {
    class Engine {
        List<Instruction> Instructions;

        public void Run (string code) {
            var parseEngine = new SkryptEngine(code);
            var programNode = parseEngine.Parse();

            programNode.Print();

            Instructions = InstructionCompiler.Compile(programNode);

            PrintInstructions();
        }

        public void PrintInstructions () {
            Console.WriteLine("Instructions: ");

            for (int i = 0; i < Instructions.Count; i++) {
                var index = i.ToString("X4");

                Console.WriteLine(index + ": " + Instructions[i]);
            }
        }
    }
}