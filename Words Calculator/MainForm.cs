﻿using System;
using System.Windows.Forms;

/// <summary>
/// Осуществляет работу с событиями
/// </summary>
namespace Words_Calculator
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            grbPartsOfSpeech.Enabled = WordCalculator.IsOpenFile;
            grbOutputOptions.Enabled = WordCalculator.IsOpenFile;
            btnSearch.Enabled = WordCalculator.IsOpenFile;
        }

        /// <summary>
        /// Нажатие кнопки "Искать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            WordCalculator.readInputEndsFile();

            WordCalculator.divideIntoSentences();
            
            WordCalculator.writeFileWithSentenceNumber();
            
            WordCalculator.divideIntoWords();
            
            WordCalculator.findAdjectivesWithMinFirstKindError();
            
            WordCalculator.findAdjectivesWithMinSecondKindError();
            
            WordCalculator.countWordAmount();
            
            WordCalculator.correctWordAmount();

            WordCalculator.sortOfWords();
            
            WordCalculator.writeInFiles();

            WordCalculator.clearData();
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
                chbNoun.Checked = chbAll.Checked;
                chbAdjective.Checked = chbAll.Checked;
                chbVerb.Checked = chbAll.Checked;
                chbAdverb.Checked = chbAll.Checked;
                chbParticiple.Checked = chbAll.Checked;
                chbDeeprichastie.Checked = chbAll.Checked;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            WordCalculator.readInputTextFile();
            grbPartsOfSpeech.Enabled = WordCalculator.IsOpenFile;
            grbOutputOptions.Enabled = WordCalculator.IsOpenFile;
            btnSearch.Enabled = WordCalculator.IsOpenFile;
        }
    }
}
